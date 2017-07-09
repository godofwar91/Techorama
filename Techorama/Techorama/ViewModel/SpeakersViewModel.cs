using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techorama.Models;

namespace Techorama.ViewModel
{
    public class SpeakersViewModel : ViewModelBase
    {
        private ObservableCollection<Speaker> _Speakers;
        public ObservableCollection<Speaker> Speakers
        {
            get { return _Speakers; }
            set
            {
                _Speakers = value;
                RaisePropertyChanged(() => Speakers);
            }
        }

        private ObservableCollection<Speaker> _OriginalSpeakers;
        public ObservableCollection<Speaker> OriginalSpeakers
        {
            get { return _OriginalSpeakers; }
            set
            {
                _OriginalSpeakers = value;
                RaisePropertyChanged(() => OriginalSpeakers);
            }
        }

        public void GetSpeakersBy(string track, List<Session> sessions)
        {
            List<Speaker> subSpeaker = new List<Speaker>();
            List<Speaker> speakers = this.OriginalSpeakers.ToList();

            List<Session> subSessions = sessions.Where(x => x.Track == track).ToList();

            if(subSessions!=null)
            {
                foreach(Session session in subSessions)
                {
                    Speaker speaker = this.OriginalSpeakers.Where(x => x.Name == session.Speaker).FirstOrDefault();
                    if(speaker!=null)
                        subSpeaker.Add(speaker); 
                }
                this.Speakers = new ObservableCollection<Speaker>(subSpeaker);
            }
           
        }
    }
}
