using Repositories;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var list = RadarJsonRepository.GetData("C:\\json\\dados_dos_radares.json");

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
