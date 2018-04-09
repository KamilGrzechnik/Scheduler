using Prism.Events;

namespace Scheduler.Model.Events
{
    public static class GlobalEvent
    {
        private static IEventAggregator _eventAggregator;

        public static IEventAggregator GetEventAggregator()
        {
            if (_eventAggregator == null)
            {
                _eventAggregator = new EventAggregator();
            }
            return _eventAggregator;
        }
    }
}
