using Shop.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Service;
using Shop.View;
using Shop.Model;

namespace Shop.Controler
{
    internal class ShopControler
    {
        private ShopService _service;
        public ShopControler(ShopService service)
        {
            _service = service;
        }
        public double ShopControlerCal(ShopModel model)
        {
            return _service.Calculate(model);
        }
    }
}
