using Repositories;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var list = RadarJsonRepository.GetData("C:\\Users\\ADM\\Desktop\\Formação C#\\IngestãoXRadar\\dados_dos_radares.json");

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Inserir todos os regitros nos bancos de dados");
            RadarSqlRepository.Insert(list);
            
        }
    }
}
