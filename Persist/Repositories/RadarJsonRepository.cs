﻿using Models;
using Newtonsoft.Json;

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
    }
}
