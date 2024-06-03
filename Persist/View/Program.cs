﻿using Controllers;
using Models;
using Repositories;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //var list = RadarJsonRepository.GetData("C:\\Users\\ADM\\Desktop\\Formação C#\\IngestãoXRadar\\dados_dos_radares.json"); dai
            var list = RadarJsonRepository.GetData("C:\\json\\dados_dos_radares.json");

            Console.WriteLine("Inserir todos os regitros nos bancos de dados SQL");
            DadoRadarSqlController dadoRadarSqlController = new DadoRadarSqlController();
            dadoRadarSqlController.Insert(list);

            List<DadoRadar> listaRadarSql = dadoRadarSqlController.GetAll();

            //DadoRadarMongoController dadoRadarMongoController = new DadoRadarMongoController();
            //dadoRadarMongoController.Insert(listaRadarSql);
            
        }
    }
}
