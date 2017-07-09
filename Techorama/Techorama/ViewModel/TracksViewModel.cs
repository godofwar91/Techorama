using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techorama.Helpers;
using Techorama.Models;

namespace Techorama.ViewModel
{
    public class TracksViewModel : ViewModelBase
    {
        private ObservableCollection<Grouping<String, Session>> _TrackSessionGrouping;
        public ObservableCollection<Grouping<String, Session>> TrackSessionGrouping
        {
            get { return _TrackSessionGrouping; }
            set
            {
                _TrackSessionGrouping = value;
                RaisePropertyChanged(() => TrackSessionGrouping);
            }
        }

        public void SetGroupingTrackToSessions(List<Track> tracks, List<Session> sessions)
        {
            List<Grouping<String, Session>> groupingStringToSession = new List<Grouping<string, Session>>();
            Dictionary<String, List<Session>> mapRoomToSession = new Dictionary<string, List<Session>>();
            if (tracks != null && sessions != null)
            {
                foreach (Track track in tracks)
                {
                    if (!mapRoomToSession.ContainsKey(track.Name))
                    {
                        mapRoomToSession.Add(track.Name, new List<Session>());
                    }
                    List<Session> sessionsForRoom = sessions.Where(x => x.Track == track.Name).ToList();
                    mapRoomToSession[track.Name] = sessionsForRoom;
                }
                foreach (KeyValuePair<string, List<Session>> couple in mapRoomToSession)
                {
                    groupingStringToSession.Add(new Grouping<string, Session>(couple.Key, couple.Value));
                }
            }
            this.TrackSessionGrouping = new ObservableCollection<Grouping<string, Session>>(groupingStringToSession);
        }
    }
}
