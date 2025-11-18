using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Controler;
using Shop.Model;

namespace Shop.Service
{
    internal class ShopService
    {
        private double _priceZperKG;
        private double _pricePperKG;
        public double Calculate(ShopModel model)
        {
            _priceZperKG = model.PriceZ * model.KgZ;
            _pricePperKG = model.PriceP * model.KgP;
            model.Price = _priceZperKG + _pricePperKG;
            model.Price *= 0.50;
            return model.Price;
        }
    }
}
