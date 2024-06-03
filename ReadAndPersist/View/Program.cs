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

            DadosRadaresSqlController dadosRadaresSqlController = new DadosRadaresSqlController();;
            List<DadosRadares> listaRadarSql = dadosRadaresSqlController.GetAll();

            DadosRadaresMongoController dadosRadaresMongoController = new DadosRadaresMongoController();
            dadosRadaresMongoController.Insert(listaRadarSql);
        }
    }
}
