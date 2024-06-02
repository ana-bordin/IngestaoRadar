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

        public bool Insert(List<DadoRadar> dadosRadares)
        {
            return _service.Insert(dadosRadares);
        }

        public List<DadoRadar> GetAll()
        {
            return _service.GetAll();
        }
       
    }
}
