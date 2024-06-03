using Models;
using MongoDB.Driver;

namespace Repositories
{
    public class RadarMongoRepository
    {
        static readonly string _connectionString = "mongodb://root:Mongo%402024%23@localhost:27017";
        static MongoClient _mongoClient = new MongoClient(_connectionString);
        static IMongoDatabase _database = _mongoClient.GetDatabase("AdmRadar");

        public bool Insert(List<DadosRadares> dadosRadares)
        {
            var mongoClient = new MongoClient(_connectionString);
            var collection = _database.GetCollection<DadosRadares>("DadosRadares");
            try
            {
                collection.InsertMany(dadosRadares);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
