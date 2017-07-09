using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techorama.Models
{
    public class CacheSessions
    {

        private static CacheSessions instance;

        public List<Session> Sessions { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Track> Tracks { get; set; }
        public List<Speaker> Speakers { get; set; }


        public static CacheSessions Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CacheSessions();
                }
                return instance;
            }
        }
    }
}
