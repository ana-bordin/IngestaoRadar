using Models;
using Services;

namespace Controllers
{
    public class DadoRadarController
    {
        private readonly DadoRadarService _service;

        public DadoRadarController()
        {
            _service = new DadoRadarService();
        }

        public bool Insert(List<DadoRadar> dadosRadares)
        {
            return _service.Insert(dadosRadares);
        }
        
        //public static void InsertJson(List<DadoRadar> lista)
        //{
        //    DadoRadarController dadoRadarController = new DadoRadarController();
            
        //    foreach (var item in lista)
        //    {
        //        dadoRadarController.Insert(item);
        //    }
        //}
    }
}
