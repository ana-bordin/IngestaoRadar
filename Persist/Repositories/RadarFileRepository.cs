using CsvHelper;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Repositories
{
    public class RadarFileRepository
    {
        static string pasta = "C:\\Users\\ADM\\Desktop\\Formação C#\\DadosRadares\\";
        public static void CheckExists(string file)
        {
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            if (!File.Exists(pasta + file))
            {
                StreamWriter sw = new(pasta + file);
                sw.Close();
            }
        }
        public static void DadosJson (List<DadosRadares> dados) 
        {
            CheckExists("DadosJson.Json");
            string json = JsonConvert.SerializeObject (dados);
            StreamWriter streamWriter = new StreamWriter(pasta + "DadosJson.Json");
            streamWriter.Write (json);
            streamWriter.Close ();
        }

        public static void DadosCsv(List<DadosRadares> dados)
        {
            CheckExists("DadosCsv.Csv");

            using (var streamWriter = new StreamWriter(pasta + "DadosCsv.Csv"))
            using (var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(dados);

            }
        }
        //Aqui, um objeto CsvWriter é inicializado para escrever dados em formato CSV. Ele é inicializado com um objeto StreamWriter chamado streamWriter e com a cultura invariante (CultureInfo.InvariantCulture). A cultura invariante é usada para garantir que o formato dos números e datas seja consistente, independentemente das configurações regionais do sistema.
        
        public static void DadosXml(List<DadosRadares> dados)
        {
            CheckExists("DadosXml.Xml");
            
            XmlSerializer xml = new XmlSerializer(typeof(List<DadosRadares>));
            // cria um obj que converte com um arquivo .xml

            TextWriter writer = new StreamWriter(pasta + "DadosXml.Xml");
            // mesma coisa que o streamWriter

            xml.Serialize(writer, dados);
            // grava com o textWrite no arquivo, a lista de dados
            
            writer.Close();
        }
    }
}
