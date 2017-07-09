using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techorama.Models
{
    public class Session
    {
        Int32 id;
        string title;
        string description;
        string speaker;
        string room;
        string track;
        DateTime start;
        DateTime end;

        [JsonProperty(PropertyName = "id")]
        public int Id { get { return id; } set { id = value; } }
        [JsonProperty(PropertyName = "title")]
        public string Title { get { return title; } set { title = value; } }
        [JsonProperty(PropertyName = "description")]
        public string Description { get { return description; } set { description = value; } }
        [JsonProperty(PropertyName = "speaker")]
        public string Speaker { get { return speaker; } set { speaker = value; } }
        [JsonProperty(PropertyName = "room")]
        public string Room { get { return room; } set { room = value; } }
        [JsonProperty(PropertyName = "track")]
        public string Track { get { return track; } set { track = value; } }
        /*private DateTime START;
        private DateTime END;
        public string StartText { get; set; }
        public string EndText { get; set; }*/

        [JsonProperty(PropertyName = "start")]
        public DateTime Start { get; set; }


       

        [JsonProperty(PropertyName = "end")]
        public DateTime End { get; set; }
       
        /*[JsonProperty(PropertyName = "start")]
        public DateTime Start { get { return start; } set { start = value; } }
        [JsonProperty(PropertyName = "end")]
        public DateTime End { get { return end; } set { end = value; } }*/


    }
}
