using Models;
using Repositories;
using System.Collections.Generic;

namespace Services
{
    public class DadoRadarService
    {
        private readonly RadarSqlRepository _repository;

        public DadoRadarService()
        {
            _repository = new RadarSqlRepository();
        }
        public bool Insert(List<DadoRadar> dadosRadares)
        {
            return _repository.Insert(dadosRadares);
        }
    }
}
