using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MDK0101_3_2026
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //2 вкладка
        private CancellationTokenSource _cts;

        //3 вкладка
        private readonly Dictionary<string, Func<string, string>> _operations = new()
        {
            ["Верхний регистр"] = s => s.ToUpper(), //лямбда преоб в верхний регистр
            ["Реверс"] = s => new string(s.Reverse().ToArray()), //лямбда реверса
            ["Без изменений"] = s => s, //лямбда где строка не меняется
        };

        //4 вкладка
        Counter counter = new Counter();

        public MainWindow()
        {
            InitializeComponent();
            _cts = new CancellationTokenSource();
        }

        // 1 вкладка - делегат как входной параметр
        private void OpenChildButton_Click(object sender, RoutedEventArgs e)
        {
            ChildWindow child = new ChildWindow(text =>
                ResultTextBlock.Text = text);
            child.Show();
        }

        // 2 вкладка - получение колбека процесса из другого потока
        private async void StartTaskButton_Click(object sender, RoutedEventArgs e)
        {
            
            var service = new LongTaskService();
            var progress = new Progress<int>(p => TaskProgressBar.Value = p);

            await Task.Run(() => service.Process
            (
                100,
                p => ((IProgress<int>)progress).Report(p),
                () => _cts.IsCancellationRequested
            ));
        }

        private void CancelTaskButton_Click(object sender, RoutedEventArgs e)
        {
            _cts.Cancel();
            TaskProgressBar.Value = 0;
            if(_cts.TryReset())
            {
                _cts = new CancellationTokenSource();
            }
        }

        private void ApplyStrategyButton_Click(object sender, RoutedEventArgs e)
        {
            var keyItem = StrategyComboBox.SelectedItem as ComboBoxItem;
            var key = keyItem.Content.ToString();

            if (key is null)
                return;

            if (_operations.TryGetValue(key, out var function))
            {
                StrategyOutputTextBlock.Text = function(StrategyInputTextBox.Text);
            }
        }

        private void TabItem_Loaded(object sender, RoutedEventArgs e)
        {
            counter.Subscribe(c => LogTextBox.Text += $"[log] {c} - {DateTime.Now}\n");
            counter.Subscribe(c => ValuesListBox.Items.Add(c));
        }

        private void IncrementButton_Click(object sender, RoutedEventArgs e)
        {
            counter.Work();
        }

        //----------------------------5----------------------------------
        private void AddValidatedButton_Click(object sender, RoutedEventArgs e)
        {

        }

        //----------------------------6----------------------------------
        private void ClearCanvasButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SortButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ResetListButton_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}