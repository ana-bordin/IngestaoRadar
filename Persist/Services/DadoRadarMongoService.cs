using Models;
using Repositories;
using System.Collections.Generic;

namespace Services
{
    public class DadoRadarMongoService
    {
        private readonly RadarMongoRepository _repository;

        public DadoRadarMongoService()
        {
            _repository = new RadarMongoRepository();
        }
        public bool Insert(List<DadosRadares> dadosRadares)
        {
            return _repository.Insert(dadosRadares);
        }
    }
}
