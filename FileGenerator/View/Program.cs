using Models;
using Controllers;
using Repositories;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<DadosRadares> dados = new List<DadosRadares>();
            // criar lista dados sql
            
            DadosRadaresSqlController dadosRadaresSqlController = new DadosRadaresSqlController();
            // criar obj controller pra chamar os metodos dele

            dados = dadosRadaresSqlController.GetAll();

            RadarFileRepository.DadosJson(dados);
            ////jogar lista pro arquivo .json

            RadarFileRepository.DadosCsv(dados);
            ////joga lista pro arquivo .csv

            RadarFileRepository.DadosXml(dados);



        }
    }
}
