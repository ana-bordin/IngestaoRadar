using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Models
{
    public class DadosRadares
    {
        public static readonly string INSERTSQL = "INSERT INTO DadosRadares (Concessionaria, AnoDoPnvSnv, TipoDeRadar, Rodovia, Uf, KmM, Municipio, TipoPista, Sentido, Situacao, DataDaInativacao, Latitude, Longitude, VelocidadeLeve) VALUES (@Concessionaria, @AnoDoPnvSnv, @TipoDeRadar, @Rodovia, @Uf, @KmM, @Municipio, @TipoPista, @Sentido, @Situacao, @DataDaInativacao, @Latitude, @Longitude, @VelocidadeLeve)";

        public static readonly string UPDATESQL = "UPDATE DadosRadares SET AnoDoPnvSnv = '{radar.AnoDoPnvSnv}', TipoDeRadar = '{radar.TipoDeRadar}', Rodovia = '{radar.Rodovia}', Uf = '{radar.Uf}', KmM = '{radar.KmM}', Municipio = '{radar.Municipio}', TipoPista = '{radar.TipoPista}', Sentido = '{radar.Sentido}', Situacao = '{radar.Situacao}', DataDaInativacao = '{radar.DataDaInativacao}', Latitude = '{radar.Latitude}', Longitude = '{radar.Longitude}', VelocidadeLeve = '{radar.VelocidadeLeve}' WHERE Id = {id}";

        public static readonly string DELETESQL = "UPDATE DadosRadares SET DataDaInativacao = CONVERT(date, GETDATE()), Situacao = 'Inativo' WHERE Id = {id}";

        public static readonly string GETALLSQL = "SELECT Id, Concessionaria, AnoDoPnvSnv, TipoDeRadar, Rodovia, Uf, KmM, Municipio, TipoPista, Sentido, Situacao, DataDaInativacao, Latitude, Longitude, VelocidadeLeve FROM DadosRadares";

        public static readonly string GETBYIDSQL = "SELECT Id, Concessionaria, AnoDoPnvSnv, TipoDeRadar, Rodovia, Uf, KmM, Municipio, TipoPista, Sentido, Situacao, DataDaInativacao, Latitude, Longitude, VelocidadeLeve FROM DadosRadares WHERE Id = {id}";

        public int Id { get; set; }

        [JsonProperty("concessionaria")]
        public string Concessionaria { get; set; }
        
        [JsonProperty("ano_do_pnv_snv")]
        public string AnoDoPnvSnv { get; set; }
        
        [JsonProperty("tipo_de_radar")]
        public string TipoDeRadar { get; set; }
        
        [JsonProperty("rodovia")]
        public string Rodovia { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("km_m")]
        public string KmM { get; set; }

        [JsonProperty("municipio")]
        public string Municipio { get; set; }

        [JsonProperty("tipo_pista")]
        public string TipoPista { get; set; }

        [JsonProperty("sentido")]
        public string Sentido { get; set; }

        [JsonProperty("situacao")]
        public string Situacao { get; set; }

        [JsonProperty("data_da_inativacao")]
        //public List<string> DataDaInativacao { get; set; }
        public char[] DataDaInativacao { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("velocidade_leve")]
        public string VelocidadeLeve { get; set; }

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
