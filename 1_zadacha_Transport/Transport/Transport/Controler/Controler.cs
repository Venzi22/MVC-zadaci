using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.View;
using Transport.Model;

namespace Transport.Controler
{
    internal class Controler
    {
        private View.View view;
        private Model.Model model;
        private Service.Service Service;

        public  Controler(Service.Service service) 
        {
            Service = service;
        }

        public double ControlerCal(Model.Model model)
        {
            if (model.Km < 20)
            {
                return Service.Taxi(model);
            }
            else if (model.Km >= 20 && model.Km < 100)
            {
                return Service.Bus(model);
            }
            else
            {
                return Service.Train(model);
            }
        }
    }
}
