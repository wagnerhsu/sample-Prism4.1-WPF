using AboutModule.ViewModels;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace AboutModule.Views
{
    /// <summary>
    /// Interaction logic for AboutUserControl.xaml
    /// </summary>
    public partial class AboutUserControl : UserControl
    {
        IEventAggregator _eventAggregator;
        public AboutUserControl(IEventAggregator eventAggregator, AboutViewModel aboutViewModel)
        {
            InitializeComponent();
            DataContext = aboutViewModel; 
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<TestEvent>().Publish("From About User Control");
        }
    }
}
