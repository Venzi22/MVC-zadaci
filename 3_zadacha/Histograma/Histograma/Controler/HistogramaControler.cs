using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using Histograma.View;
using Histograma.Service;

namespace Histograma.Controler
{
    internal class HistogramaControler
    {
        private HistogramaService service;

        public HistogramaControler(HistogramaService service)
        {
            this.service = service;
        }
        public void Controler(Model.HistogramaModel model)
        {
            service.Service(model);
        }
        public void ControlerP(Model.HistogramaModel model)
        {
            service.Procent1(model);
            service.Procent2(model);
            service.Procent3(model);
            service.Procent4(model);
            service.Procent5(model);
        }
    }
}
