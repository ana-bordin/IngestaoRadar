using Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Repositories
{
    public class RadarJsonRepository
    {
        public static List<RadarData> GetData(string path)
        {
            StreamReader reader = new StreamReader(path);
            string jsonString = reader.ReadToEnd();

            var obj = JsonConvert.DeserializeObject<Radar>(jsonString);

            //if (obj != null) return 
            //        obj.Radars;
            return obj.Radars;
        }

        //string stringConnection = "Server=127.0.0.1;Database=Radar;User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True";
        //SqlConnection connection;

        //public RadarRepository()
        //{
        //    connection = new SqlConnection(stringConnection);
        //    connection.Open();
        //}
    }
}
