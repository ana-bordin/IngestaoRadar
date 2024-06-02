using Newtonsoft.Json;

namespace Models
{
    public class Radar
    {
        [JsonProperty("radar")]
        public List<DadosRadares> Radars { get; set; }
    }
}
