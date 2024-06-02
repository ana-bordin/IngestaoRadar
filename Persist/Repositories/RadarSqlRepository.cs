using Microsoft.Data.SqlClient;
using Models;
using MongoDB.Driver;
using System.Data;
using System.Text;

namespace Repositories
{
    public class RadarSqlRepository
    {
        static readonly string _connectionString = "Server=127.0.0.1; Database=AdmRadar; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True";
        static SqlConnection _connection;

        public RadarSqlRepository()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        public bool Insert(List<DadoRadar> dadosRadares)
        {
            SqlCommand command = new SqlCommand(DadoRadar.INSERTSQL, _connection);
            try
            {
                var dataTable = new DataTable();

                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Concessionaria", typeof(string));
                dataTable.Columns.Add("AnoDoPnvSnv", typeof(int));
                dataTable.Columns.Add("TipoDeRadar", typeof(string));
                dataTable.Columns.Add("Rodovia", typeof(string));
                dataTable.Columns.Add("Uf", typeof(string));
                dataTable.Columns.Add("KmM", typeof(decimal));
                dataTable.Columns.Add("Municipio", typeof(string));
                dataTable.Columns.Add("TipoPista", typeof(string));
                dataTable.Columns.Add("Sentido", typeof(string));
                dataTable.Columns.Add("Situacao", typeof(string));
                dataTable.Columns.Add("DataDaInativacao", typeof(string));
                dataTable.Columns.Add("Latitude", typeof(decimal));
                dataTable.Columns.Add("Longitude", typeof(decimal));
                dataTable.Columns.Add("VelocidadeLeve", typeof(int));

                int line = 0;
                int totalItems = 0;

                foreach (var item in dadosRadares)
                {
                    totalItems++;
                    line++;
                    dataTable.Rows.Add(null, item.Concessionaria, item.AnoDoPnvSnv, item.TipoDeRadar, item.Rodovia, item.Uf, item.KmM, item.Municipio, item.TipoPista, item.Sentido, item.Situacao, item.DataDaInativacao, item.Latitude, item.Longitude, item.VelocidadeLeve);

                    if (line == 100 || totalItems == dadosRadares.Count)
                    {
                        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(_connection))
                        {
                            bulkCopy.DestinationTableName = "DadoRadar";
                            bulkCopy.WriteToServer(dataTable);
                            dataTable.Clear();
                            line = 0;
                        }
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro ao inserir no banco de dados:" + e);
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public List<DadoRadar> GetAll()
        {
            List<DadoRadar> radares = new List<DadoRadar>();
            StringBuilder sb = new StringBuilder();
            sb.Append(DadoRadar.GETALLSQL);
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(DadoRadar.GETALLSQL, _connection);
                //SqlCommand command = new SqlCommand(sb.ToString(), _connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DadoRadar radar = new DadoRadar();
                        radar.Id = reader.GetInt32(0);
                        radar.Concessionaria = reader.GetString(1);
                        radar.AnoDoPnvSnv = reader.GetInt32(2).ToString();
                        radar.TipoDeRadar = reader.GetString(3);
                        radar.Rodovia = reader.GetString(4);
                        radar.Uf = reader.GetString(5);
                        radar.KmM = reader.GetDecimal(6).ToString();
                        radar.Municipio = reader.GetString(7);
                        radar.TipoPista = reader.GetString(8);
                        radar.Sentido = reader.GetString(9);
                        radar.Situacao = reader.GetString(10);
                        radar.DataDaInativacao = reader.GetString(11).ToArray();
                        radar.Latitude = reader.GetDecimal(12).ToString();
                        radar.Longitude = reader.GetDecimal(13).ToString();
                        radar.VelocidadeLeve = reader.GetInt32(14).ToString();
                        radares.Add(radar);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                _connection.Close();
            }
            return radares;
        }
    }
}
