using Models;
using Services;

namespace Controllers
{
    public class DadoRadarMongoController
    {
        private readonly DadoRadarMongoService _service;

        public DadoRadarMongoController()
        {
            _service = new DadoRadarMongoService();
        }

        public bool Insert(List<DadoRadar> dadosRadares)
        {
            return _service.Insert(dadosRadares);
        }
       
    }
}
