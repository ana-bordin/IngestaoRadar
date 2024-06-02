using Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Linq;

namespace Repositories
{
    public class RadarJsonRepository
    {
        public static List<DadosRadares> GetData(string path)
        {
            StreamReader reader = new StreamReader(path);
            string jsonString = reader.ReadToEnd();
            var obj = JsonConvert.DeserializeObject<Radar>(jsonString);

            return obj.Radars;
        }

        //public static void EscapedWords(List<DadoRadar> list)
        //{
        //        foreach (var item in list)
        //        {
        //        item.AnoDoPnvSnv.
        //            item.AnoDoPnvSnv = item.AnoDoPnvSnv.Replace("\"", "");

        //        if (item.NomeMotorista.Contains("'"))
        //            item.NomeMotorista = item.NomeMotorista.Replace("'", "''");
        //    }
        //    }





    }
}
