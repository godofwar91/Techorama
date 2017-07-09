using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techorama.Models
{
    public class Track
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
