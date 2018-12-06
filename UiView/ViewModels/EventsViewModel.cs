using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameModel.ViewModels;

namespace UiView.ViewModels
{
    class EventsViewModel : ViewModelBase
    {
        public string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }
        public string _ModelChanges;

        public string ModelChanges
        {
            get { return _ModelChanges; }
            set
            {
                _ModelChanges = value;
                OnPropertyChanged("ModelChanges");
            }
        }
    }
}
