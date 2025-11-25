using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
namespace Transport.View
{
    internal class View
    {
        public double Km;
        public string TimeOfDay;
        public double price;

        private Controler.Controler _controler;
        public View(Controler.Controler controler) 
        {
            _controler = controler;
        }
        public void GetValues()
        {
            Console.WriteLine("Enter the distance you want to travel (in km): ");
            Km = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time of day (day/night): ");
            TimeOfDay = Console.ReadLine();
            var model = new Model.Model(Km, TimeOfDay, price);
            var contol = _controler.ControlerCal(model);
            Console.WriteLine(model.Price);
        }

    }
}
