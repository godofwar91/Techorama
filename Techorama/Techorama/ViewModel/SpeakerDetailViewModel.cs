using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techorama.Models;

namespace Techorama.ViewModel
{
    public class SpeakerDetailViewModel : ViewModelBase
    {

        private Session _Session;
        public Session Session
        {
            get { return _Session; }
            set
            {
                _Session = value;
                RaisePropertyChanged(() => Session);
            }
        }
    }
}
