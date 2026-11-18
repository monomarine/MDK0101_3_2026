using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EventsDemo
{
    /// <summary>
    /// Логика взаимодействия для ChildWindow.xaml
    /// </summary>
    public partial class ChildWindow : Window
    {
        public event EventHandler<MessageEventArgs> TextChanged;
        public ChildWindow()
        {
            InitializeComponent();
        }

        private void SendAndCloseButton_Click(object sender, RoutedEventArgs e)
        {
            TextChanged?.Invoke(this, new MessageEventArgs(inputTB.Text));
            this.Close();
        }
    }
}
