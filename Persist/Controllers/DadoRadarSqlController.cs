using Models;
using Services;

namespace Controllers
{
    public class DadoRadarSqlController
    {
        private readonly DadoRadarSqlService _service;

        public DadoRadarSqlController()
        {
            _service = new DadoRadarSqlService();
        }

        public bool Insert(List<DadosRadares> dadosRadares)
        {
            return _service.Insert(dadosRadares);
        }

        public List<DadosRadares> GetAll()
        {
            return _service.GetAll();
        }
       
    }
}
