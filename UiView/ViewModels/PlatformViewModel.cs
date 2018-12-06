using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameModel.ViewModels;

namespace UiView.ViewModels
{
    class PlatformViewModel : ViewModelBase
    {

        public string _PlatformType;

        public string PlatformType
        {
            get { return _PlatformType; }
            set
            {
                _PlatformType = value;
                OnPropertyChanged("PlatformType");
            }
        }
        public string _Position;

        public string Position
        {
            get { return _Position; }
            set
            {
                _Position = value;
                OnPropertyChanged("Position");
            }
        }
    }
}
