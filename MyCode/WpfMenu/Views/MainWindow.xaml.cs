using AboutModule;
using Microsoft.Practices.Prism.Events;
using System;
using System.Windows;

namespace WpfMenu.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IEventAggregator _eventAggregator;

        public MainWindow(IEventAggregator eventAggregator)
        {
            InitializeComponent();
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<TestEvent>().Subscribe(x =>
            {
                statusTextBlock.Text += x + DateTime.Now.ToString();
            }, ThreadOption.UIThread);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            new AboutWindow().ShowDialog();
        }
    }
}