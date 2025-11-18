using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.Controler;

namespace Transport.Model
{
    internal class Model
    {
        private double km;
        public double Km
        {
            get { return km; }
            set { km = value; }
        }

        private string timeOfDay;
        public string TimeOfDay
        {
            get { return timeOfDay; }
            set { timeOfDay = value; }
        }
        private double price;
        public double Price 
        {
            get { return price; }
            set { price = value; }
        }
        public Model(double km, string timeOfDay, double price)
        {
            Km = km;
            TimeOfDay = timeOfDay;
            Price = price;
        }
    }
}
