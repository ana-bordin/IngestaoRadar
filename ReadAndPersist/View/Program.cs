using Controllers;
using Models;
using Repositories;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inserir todos os regitros do Sql no banco de dados Mongo");
           
            DadoRadarSqlController dadoRadarSqlController = new DadoRadarSqlController();;
            List<DadoRadar> listaRadarSql = dadoRadarSqlController.GetAll();

            DadoRadarMongoController dadoRadarMongoController = new DadoRadarMongoController();
            dadoRadarMongoController.Insert(listaRadarSql);
        }
    }
}
