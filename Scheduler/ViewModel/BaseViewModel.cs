using MahApps.Metro.Controls.Dialogs;
using Prism.Events;
using Scheduler.Model.Events;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Scheduler.ViewModel
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        protected IDialogCoordinator _dialogCoordinator = DialogCoordinator.Instance;

        protected IEventAggregator _aggregator = GlobalEvent.GetEventAggregator();

        public BaseViewModel()
        {
            SubsribeEvents();
            InitializeCommands();
        }

        public void NotifyPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public abstract void DoIfIsCurrent();

        protected abstract void SubsribeEvents();

        protected abstract void InitializeCommands();
    }
}
