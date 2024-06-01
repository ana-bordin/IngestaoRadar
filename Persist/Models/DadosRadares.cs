using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Models
{
    public class DadosRadares
    {
        [JsonProperty("concessionaria")]
        public string Concessionaria { get; set; }
        
        [JsonProperty("ano_do_pnv_snv")]
        public int AnoDoPnvSnv { get; set; }
        
        [JsonProperty("tipo_de_radar")]
        public string TipoDeRadar { get; set; }
        
        [JsonProperty("rodovia")]
        public string Rodovia { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("km_m")]
        public decimal KmM { get; set; }

        [JsonProperty("municipio")]
        public string Municipio { get; set; }

        [JsonProperty("tipo_pista")]
        public string TipoPista { get; set; }

        [JsonProperty("sentido")]
        public string Sentido { get; set; }

        [JsonProperty("situacao")]
        public string Situacao { get; set; }

        [JsonProperty("data_da_inativacao")]
        public DateOnly[] DataDaInativacao { get; set; }

        [JsonProperty("latitude")]
        public decimal Latitude { get; set; }

        [JsonProperty("longitude")]
        public decimal Longitude { get; set; }

        [JsonProperty("velocidade_leve")]
        public int VelocidadeLeve { get; set; }

        public override string ToString() => $"Concessionaria: {Concessionaria}\n" + 
                                             $"Ano do PNV/SNV: {AnoDoPnvSnv}\n" + 
                                             $"Tipo de radar: {TipoDeRadar}\n" + 
                                             $"Rodovia: {Rodovia}\n" + 
                                             $"UF: {Uf}\n" + 
                                             $"KM: {KmM}\n" + 
                                             $"Municipio: {Municipio}\n" + 
                                             $"Tipo de pista: {TipoPista}\n" + 
                                             $"Sentido: {Sentido}\n" + 
                                             $"Situação: {Situacao}\n" + 
                                             $"Data da Inativação: {DataDaInativacao}\n" + 
                                             $"Latitude: {Latitude}\n" + 
                                             $"Longitude: {Longitude}\n" + 
                                             $"Velocidade leve: {VelocidadeLeve}\n";
    }
}
