using Microsoft.Practices.Prism.Events;

namespace AboutModule.ViewModels
{
    public class AboutViewModel
    {
        private IEventAggregator _eventAggregator;

        public AboutViewModel(IEventAggregator eventAggregator)
        {
            FileVersion = "1.0.1";
            ProductVersion = "1.1.9";
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<TestEvent>().Publish("From AboutViewModel");
        }

        public string FileVersion { get; set; }
        public string ProductVersion { get; set; }
    }
}