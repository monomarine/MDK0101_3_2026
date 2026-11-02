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

namespace MDK0101_3_2026
{
    /// <summary>
    /// Логика взаимодействия для ChildWindow.xaml
    /// </summary>
    public partial class ChildWindow : Window
    {
        private readonly Action<string> _action;
        public ChildWindow(Action<string> act)
        {
            InitializeComponent();
            _action = act;
        }

        private void ChildSendButton_Click(object sender, RoutedEventArgs e)
        {
            _action?.Invoke(ChildInputTextBox.Text);
            this.Close();
        }
    }
}
