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
        private CancellationTokenSource _cts = new();
        private bool isCancelTask = false;
        private Counter counter = new Counter();

        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 1 вкладка (передача делегата в качестве входного параметра)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenChildButton_Click(object sender, RoutedEventArgs e)
        {
            var child = new ChildWindow(text =>
                ResultTextBlock.Text = $"информация из дочернего окна - {text}"
            );
            child.Show();
        }
#pragma warning disable
        private async void StartTaskButton_Click(object sender, RoutedEventArgs e)
        {
            LongTaskService service = new LongTaskService();
            Progress<int> progress = new Progress<int>(p => TaskProgressBar.Value = p);

            Task.Run(() => service.Work(
                    56,
                    p => ((IProgress<int>)progress).Report(p),
                    () => _cts.IsCancellationRequested
                ));
        }

        private void CancelTaskButton_Click(object sender, RoutedEventArgs e)
        {

                _cts.Cancel();
                TaskProgressBar.Value = 0;

        }

        private void ApplyStrategyButton_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, Func<string, string>> options = new()
            {
                ["Верхний регистр"] = t => t.ToUpper(),
                ["Реверс"] = t => new string(t.Reverse().ToArray()),
                ["Без изменений"] = t => t
            };

            var keyItem = StrategyComboBox.SelectedItem as ComboBoxItem;
            var key = keyItem.Content.ToString();

            if(options.TryGetValue(key, out Func<string, string> fun))
            {
               StrategyOutputTextBlock.Text = fun(StrategyInputTextBox.Text);
            }
        }

        private void TabItem_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void IncrementButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}