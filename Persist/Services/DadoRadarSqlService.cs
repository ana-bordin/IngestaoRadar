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
        
        public bool Insert(List<DadosRadares> dadosRadares)
        {
            return _repository.Insert(dadosRadares);
        }

        public List<DadosRadares> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
