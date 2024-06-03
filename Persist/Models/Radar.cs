using Newtonsoft.Json;

namespace Models
{
    public class Radar
    {
        [JsonProperty("radar")]
        public List<DadoRadar> Radars { get; set; }
    }
}
