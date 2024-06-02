using Microsoft.Data.SqlClient;
using Models;
using System.Data;
using System.Text;

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

        public bool Insert(List<DadoRadar> dadosRadares)
        {
            SqlCommand command = new SqlCommand(DadoRadar.INSERT, connection);
            try
            {
                foreach (var radar in dadosRadares)
                {

                    command.Parameters.Add(new SqlParameter("@Concessionaria", radar.Concessionaria));
                    command.Parameters.Add(new SqlParameter("@AnoDoPnvSnv", radar.AnoDoPnvSnv));
                    command.Parameters.Add(new SqlParameter("@TipoDeRadar", radar.TipoDeRadar));
                    command.Parameters.Add(new SqlParameter("@Rodovia", radar.Rodovia));
                    command.Parameters.Add(new SqlParameter("@Uf", radar.Uf));
                    command.Parameters.Add(new SqlParameter("@KmM", radar.KmM));
                    command.Parameters.Add(new SqlParameter("@Municipio", radar.Municipio));
                    command.Parameters.Add(new SqlParameter("@TipoPista", radar.TipoPista));
                    command.Parameters.Add(new SqlParameter("@Sentido", radar.Sentido));
                    command.Parameters.Add(new SqlParameter("@Situacao", radar.Situacao));
                    string dataDaInativacaoStr = radar.DataDaInativacao != null ? string.Join(",", radar.DataDaInativacao) : null;
                    command.Parameters.Add(new SqlParameter("@DataDaInativacao", dataDaInativacaoStr));
                    command.Parameters.Add(new SqlParameter("@Latitude", radar.Latitude));
                    command.Parameters.Add(new SqlParameter("@Longitude", radar.Longitude));
                    command.Parameters.Add(new SqlParameter("@VelocidadeLeve", radar.VelocidadeLeve));

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
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
                connection.Close();
            }
        }

        //public bool Update(DadoRadar radar)
        //{
        //    try
        //    {
        //        SqlCommand command = new SqlCommand(DadoRadar.UPDATE, connection);
        //        command.Parameters.Add(new SqlParameter("@Concessionaria", radar.Concessionaria));
        //        command.Parameters.Add(new SqlParameter("@AnoDoPnvSnv", radar.AnoDoPnvSnv));
        //        command.Parameters.Add(new SqlParameter("@TipoDeRadar", radar.TipoDeRadar));
        //        command.Parameters.Add(new SqlParameter("@Rodovia", radar.Rodovia));
        //        command.Parameters.Add(new SqlParameter("@Uf", radar.Uf));
        //        command.Parameters.Add(new SqlParameter("@KmM", radar.KmM));
        //        command.Parameters.Add(new SqlParameter("@Municipio", radar.Municipio));
        //        command.Parameters.Add(new SqlParameter("@TipoPista", radar.TipoPista));
        //        command.Parameters.Add(new SqlParameter("@Sentido", radar.Sentido));
        //        command.Parameters.Add(new SqlParameter("@Situacao", radar.Situacao));
        //        command.Parameters.Add(new SqlParameter("@DataDaInativacao", radar.DataDaInativacao));
        //        command.Parameters.Add(new SqlParameter("@Latitude", radar.Latitude));
        //        command.Parameters.Add(new SqlParameter("@Longitude", radar.Longitude));
        //        command.Parameters.Add(new SqlParameter("@VelocidadeLeve", radar.VelocidadeLeve));

        //        command.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        return false;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}

        //public bool Delete(DadoRadar radar)
        //{
        //    try
        //    {
        //        SqlCommand command = new SqlCommand(DadoRadar.DELETE, connection);
        //        command.Parameters.Add(new SqlParameter("@Id", radar.Id));
        //        return (command.ExecuteNonQuery() > 0);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        return false;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}

        //public List<DadosRadares> GetAll()
        //{
        //    List<DadosRadares> radares = new List<DadosRadares>();
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append(DadosRadares.GETALL);
        //    try
        //    {
        //        SqlCommand command = new SqlCommand(sb.ToString(), connection);
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            DadosRadares radar = new DadosRadares();
        //            radar.Id = reader.GetInt32(0);
        //            radar.Concessionaria = reader.GetString(1);
        //            radar.AnoDoPnvSnv = reader.GetInt32(2);
        //            radar.TipoDeRadar = reader.GetString(3);
        //            radar.Rodovia = reader.GetString(4);
        //            radar.Uf = reader.GetString(5);
        //            radar.KmM = reader.GetDecimal(6);
        //            radar.Municipio = reader.GetString(7);
        //            radar.TipoPista = reader.GetString(8);
        //            radar.Sentido = reader.GetString(9);
        //            radar.Situacao = reader.GetString(10);
        //            reader.GetDateTime(11).ToString("dd,MM,yyyy").Split(',').Select(int.Parse).ToArray();
        //            radar.Latitude = reader.GetDecimal(12);
        //            radar.Longitude = reader.GetDecimal(13);
        //            radar.VelocidadeLeve = reader.GetInt32(14);
        //            radares.Add(radar);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return radares;
        //}

        //public DadosRadares GetById(int id)
        //{
        //    DadosRadares radar = new DadosRadares();
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append(DadosRadares.GETBYID);
        //    try
        //    {
        //        SqlCommand command = new SqlCommand(sb.ToString(), connection);
        //        command.Parameters.Add(new SqlParameter("@Id", id));
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            radar.Id = reader.GetInt32(0);
        //            radar.Concessionaria = reader.GetString(1);
        //            radar.AnoDoPnvSnv = reader.GetInt32(2);
        //            radar.TipoDeRadar = reader.GetString(3);
        //            radar.Rodovia = reader.GetString(4);
        //            radar.Uf = reader.GetString(5);
        //            radar.KmM = reader.GetDecimal(6);
        //            radar.Municipio = reader.GetString(7);
        //            radar.TipoPista = reader.GetString(8);
        //            radar.Sentido = reader.GetString(9);
        //            radar.Situacao = reader.GetString(10);
        //            reader.GetDateTime(11).ToString("dd,MM,yyyy").Split(',').Select(int.Parse).ToArray();
        //            radar.Latitude = reader.GetDecimal(12);
        //            radar.Longitude = reader.GetDecimal(13);
        //            radar.VelocidadeLeve = reader.GetInt32(14);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return radar;
        //}
    }
}
