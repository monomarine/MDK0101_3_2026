using System;
using System.Collections.Generic;
using System.Text;
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
    public partial class ChildWindow : Window, IDisposable
    {
        public event EventHandler<MessageEventArgs>? MessegeSenger;
        public ChildWindow()
        {
            InitializeComponent();
        }

        private void SendAndCloseButton_Click(object sender, RoutedEventArgs e)
        {
            string text = inputTB.Text;
            OnMessageSender(text);
            this.Close();
        }
        private void OnMessageSender(string message)
        {
            MessegeSenger?.Invoke(this, new MessageEventArgs(message));
        }

        public void Dispose()
        {
            MessegeSenger = null;
        }
    }
}
