using Models;
using Services;

namespace Controllers
{
    public class DadosRadaresMongoController
    {
        private readonly DadosRadaresMongoService _service;

        public DadosRadaresMongoController()
        {
            _service = new DadosRadaresMongoService();
        }

        public bool Insert(List<DadosRadares> dadosRadares)
        {
            return _service.Insert(dadosRadares);
        }
       
    }
}
