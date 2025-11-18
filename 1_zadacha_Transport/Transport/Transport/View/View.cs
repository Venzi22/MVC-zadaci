using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport;
using Transport.Controler;

namespace Transport.View
{
    internal class View
    {
        public double Km;
        public string TimeOfDay;
        public double price;

        private Controler.Controler Controler;
        public View(Controler.Controler controler) 
        {
            Controler = controler;
        }
        public void GetValues()
        {
            Console.WriteLine("Enter the distance you want to travel (in km): ");
            Km = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time of day (day/night): ");
            TimeOfDay = Console.ReadLine();
            var model = new Model.Model(Km, TimeOfDay, price);
            var contol = Controler.ControlerCal(model);
            Console.WriteLine(model.Price);

        }

    }
}
