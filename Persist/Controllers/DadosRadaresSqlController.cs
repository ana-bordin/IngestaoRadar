using Models;
using Services;

namespace Controllers
{
    public class DadosRadaresSqlController
    {
        private readonly DadosRadaresSqlService _service;

        public DadosRadaresSqlController()
        {
            _service = new DadosRadaresSqlService();
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
