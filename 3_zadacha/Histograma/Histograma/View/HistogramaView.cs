using Histograma.Controler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histograma.View
{
    internal class HistogramaView
    {
        private double p1;
        private double p2;
        private double p3;
        private double p4;
        private double p5;
        public int n;
        public int number; 

        private HistogramaControler Controler;

        public HistogramaView(HistogramaControler controler)
        {
            Controler = controler;
        }

        public void PrintView()
        {
            Console.Write("How many numbers u want: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number/s");
            var model = new Model.HistogramaModel(p1, p2, p3, p4, p5, number, n);
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                model = new Model.HistogramaModel(p1,p2,p3,p4,p5,number,n);
                Controler.Controler(model);
            }
            Controler.ControlerP(model);
            Console.WriteLine(model.P1 + "%");
            Console.WriteLine(model.P2 + "%");
            Console.WriteLine(model.P3 + "%");
            Console.WriteLine(model.P4 + "%");
            Console.WriteLine(model.P5 + "%");
        }
    }
}
