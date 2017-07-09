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
    public class RoomsViewModel : ViewModelBase
    {
        private ObservableCollection<Grouping<String, Session>> _RoomSessionGrouping;
        public ObservableCollection<Grouping<String, Session>> RoomSessionGrouping
        {
            get { return _RoomSessionGrouping; }
            set
            {
                _RoomSessionGrouping = value;
                RaisePropertyChanged(() => RoomSessionGrouping);
            }
        }

        public void SetGroupingRoomToSessions(List<Room> rooms, List<Session> sessions)
        {
            List<Grouping<String, Session>> groupingStringToSession = new List<Grouping<string, Session>>();
            Dictionary<String, List<Session>> mapRoomToSession = new Dictionary<string, List<Session>>();
            if(rooms!=null && sessions!=null)
            {
                foreach(Room room in rooms)
                {
                    if(!mapRoomToSession.ContainsKey(room.Name))
                    {
                        mapRoomToSession.Add(room.Name, new List<Session>());
                    }
                    List<Session> sessionsForRoom = sessions.Where(x => x.Room == room.Name).ToList();
                    mapRoomToSession[room.Name] = sessionsForRoom;
                }
                foreach(KeyValuePair<string, List<Session>> couple in mapRoomToSession)
                {
                    groupingStringToSession.Add(new Grouping<string, Session>(couple.Key, couple.Value));
                }
            }
            this.RoomSessionGrouping = new ObservableCollection<Grouping<string, Session>>(groupingStringToSession);
        }
       
    }
}
