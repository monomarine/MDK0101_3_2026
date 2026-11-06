using System.Collections.ObjectModel;
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


        private readonly Dictionary<string, Func<string, string>> _strategies = new()
        {
            ["Верхний регистр"] = s => s.ToUpper(),
            ["Реверс"] = s => new string(s.Reverse().ToArray()),
            ["Без изменений"] = s => s,
        };

        public MainWindow()
        {
            InitializeComponent();
            _cts = new CancellationTokenSource();

            sortableItems = new ObservableCollection<string>(items);
            ItemsListBox.ItemsSource = sortableItems;

            sortOptions = new()
            {
                ["По длине строки по возрастанию"] = (a, b) => a.Length.CompareTo(b.Length),
                ["По длине строки по убыванию"] = (a, b) => b.Length.CompareTo(a.Length),
                ["в алфавитном порядке А -> Я"] = (a, b) => string.Compare(a, b, StringComparison.CurrentCulture),
                ["в алфавитном порядке Я -> А"] = (a, b) => string.Compare(b, a, StringComparison.CurrentCulture),
                ["в случайном порядке"] = (a, b) => Random.Shared.Next(-1, 2)
               
            };

            SortModeComboBox.ItemsSource = sortOptions.Keys;
            SortModeComboBox.SelectedIndex = 0;
        }

        // 1 вкладка - делегат как входной параметр
        private void OpenChildButton_Click(object sender, RoutedEventArgs e)
        {
            ChildWindow child = new ChildWindow(text =>
                ResultTextBlock.Text = text);
            child.Show();
        }

        private void ApplyStrategyButton_Click(object sender, RoutedEventArgs e)
        {
            
            var keyItem = StrategyComboBox.SelectedItem as ComboBoxItem;
            var key = keyItem.Content.ToString();

            if (key is null)
            {
                MessageBox.Show("1");
                return;

            }


            if (!_strategies.TryGetValue(key, out var f))
            {
                MessageBox.Show(key);
                return;
            }

            StrategyOutputTextBlock.Text = f(StrategyInputTextBox.Text);
        }
    }
}