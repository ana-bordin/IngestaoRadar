using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Radar
    {
        [JsonProperty("radar")]
        public List<RadarData> Radars { get; set; }
    }
}
