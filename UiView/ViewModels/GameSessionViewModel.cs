using GameModel;
using System.Collections.ObjectModel;
using GameModel.ViewModels;


namespace UiView.ViewModels
{
    class GameSessionViewModel : ViewModelBase
    {
        private ObservableCollection<EventsViewModel> _Events;

        public ObservableCollection<EventsViewModel> Events
        {
            get
            {
                return _Events;
            }
            set
            {
                _Events = value;
                OnPropertyChanged("Events");
            }
        }
        private ObservableCollection<PlatformViewModel> _Platforms;
        public ObservableCollection<PlatformViewModel> Platforms
        {
            get { return _Platforms; }
            set { _Platforms = value; OnPropertyChanged("Platforms"); }
        }
    }
}
