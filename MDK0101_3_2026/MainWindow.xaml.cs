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