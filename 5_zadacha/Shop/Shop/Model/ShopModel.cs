using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Service;

namespace Shop.Model
{
    internal class ShopModel
    {
        private double priceZ;
        public double PriceZ
        {
            get { return priceZ; }
            set { priceZ = value; }
        }

        private double priceP;
        public double PriceP
        {
            get { return priceP; }
            set { priceP = value; }
        }
        
        private int kgZ;
        public int KgZ
        {
            get { return kgZ; }
            set { kgZ = value; }
        }

        private int kgP;
        public int KgP
        {
            get { return kgP; }
            set { kgP = value; }
        }
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public ShopModel(double priceZ, double priceP, int kgZ, int kgP, double price)
        {
            PriceZ = priceZ;
            PriceP = priceP;
            KgZ = kgZ;
            KgP = kgP;
            Price = price;
        }
    }
}
