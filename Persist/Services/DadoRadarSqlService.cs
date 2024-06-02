using Models;
using Repositories;
using System.Collections.Generic;

namespace Services
{
    public class DadoRadarSqlService
    {
        private readonly RadarSqlRepository _repository;

        public DadoRadarSqlService()
        {
            _repository = new RadarSqlRepository();
        }
        
        public bool Insert(List<DadoRadar> dadosRadares)
        {
            return _repository.Insert(dadosRadares);
        }

        public List<DadoRadar> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
