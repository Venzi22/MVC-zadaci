using Shop.Controler;
using Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Controler;

namespace Shop.View
{
    internal class ShopView
    {
        public double priceZ;
        public double priceP;
        public int kgZ;
        public int kgP;
        public double price;

        private ShopControler _controler;
        public ShopView(ShopControler controler) 
        {
            _controler = controler;
        }
        public void View()
        {
            priceZ = double.Parse(Console.ReadLine());
            priceP = double.Parse(Console.ReadLine());
            kgZ = int.Parse(Console.ReadLine());
            kgP = int.Parse(Console.ReadLine());
            var model = new ShopModel(priceZ, priceP, kgZ, kgP, price);
            var Controler = _controler.ShopControlerCal(model);
            Console.WriteLine(model.Price);
        }
    }
}
