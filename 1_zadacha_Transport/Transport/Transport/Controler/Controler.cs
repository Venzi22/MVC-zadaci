using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Transport.Controler
{
    internal class Controler
    {
        private View.View _view;
        private Model.Model _model;
        private Service.Service _service;

        public  Controler(Service.Service service) 
        {
            _service = service;
        }

        public double ControlerCal(Model.Model model)
        {
            if (model.Km < 20)
            {
                return _service.Taxi(model);
            }
            else if (model.Km >= 20 && model.Km < 100)
            {
                return _service.Bus(model);
            }
            else
            {
                return _service.Train(model);
            }
        }
    }
}
