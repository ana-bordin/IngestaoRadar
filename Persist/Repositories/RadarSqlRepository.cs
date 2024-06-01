﻿using Microsoft.Data.SqlClient;
using Models;
namespace Repositories
{
    public class RadarSqlRepository
    {
        static string ConnectionString = "Server=127.0.0.1; Database=AdmRadar; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True";
        static SqlConnection connection;

        public RadarSqlRepository()
        {
            connection = new SqlConnection(ConnectionString);
            connection.Open();
        }
        public static bool Insert(List<DadosRadares> radares)
        {
            try
            {
                foreach (var radar in radares)
                {
                    var query = $"INSERT INTO DadosRadares (Concessionaria, AnoDoPnvSnv, TipoDeRadar, Rodovia, Uf, KmM, Municipio, TipoPista, Sentido, Situacao, DataDaInativacao, Latitude, Longitude, VelocidadeLeve) VALUES ('{radar.Concessionaria}', '{radar.AnoDoPnvSnv}', '{radar.TipoDeRadar}', '{radar.Rodovia}', '{radar.Uf}', '{radar.KmM}', '{radar.Municipio}', '{radar.TipoPista}', '{radar.Sentido}', '{radar.Situacao}', '{radar.DataDaInativacao}', '{radar.Latitude}', '{radar.Longitude}', '{radar.VelocidadeLeve}')";
                    var command = new SqlCommand(query, connection);
                    var result = command.ExecuteNonQuery();                
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Update(DadosRadares radar)
        {
            try
            {
                var query = $"UPDATE DadosRadares SET AnoDoPnvSnv = '{radar.AnoDoPnvSnv}', TipoDeRadar = '{radar.TipoDeRadar}', Rodovia = '{radar.Rodovia}', Uf = '{radar.Uf}', KmM = '{radar.KmM}', Municipio = '{radar.Municipio}', TipoPista = '{radar.TipoPista}', Sentido = '{radar.Sentido}', Situacao = '{radar.Situacao}', DataDaInativacao = '{radar.DataDaInativacao}', Latitude = '{radar.Latitude}', Longitude = '{radar.Longitude}', VelocidadeLeve = '{radar.VelocidadeLeve}' WHERE Concessionaria = '{radar.Concessionaria}'";
                var command = new SqlCommand(query, connection);
                var result = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Delete(DadosRadares radar)
        {
            try
            {
                var query = $"UPDATE DadosRadares SET DataDaInativacao = CONVERT(date, GETDATE()) WHERE Concessionaria = {radar.Concessionaria}";
                var command = new SqlCommand(query, connection);
                var result = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}