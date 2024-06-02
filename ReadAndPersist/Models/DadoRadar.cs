namespace Models
{
    public class DadoRadar
    {
        public int Id { get; set; }

        public string Concessionaria { get; set; }

        public string AnoDoPnvSnv { get; set; }

        public string TipoDeRadar { get; set; }

        public string Rodovia { get; set; }

        public string Uf { get; set; }

        public string KmM { get; set; }

        public string Municipio { get; set; }

        public string TipoPista { get; set; }

        public string Sentido { get; set; }

        public string Situacao { get; set; }

        public char[] DataDaInativacao { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

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
<<<<<<< HEAD
=======
}
>>>>>>> persistDataInsert
