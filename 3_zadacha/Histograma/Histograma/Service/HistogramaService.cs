using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Histograma.Model;
using Histograma.View;

namespace Histograma.Service
{
    internal class HistogramaService
    {
        private int numbersInLessThen200 = 0;
        private int numbers200_399 = 0;
        private int numbers400_599 = 0;
        private int numbers600_799 = 0;
        private int numbersInMoreThen800 = 0;
        public void Service(HistogramaModel model)
        {
            if (model.Number < 200)
            {
                numbersInLessThen200++;
            }
            else if (model.Number >= 200 && model.Number <= 399)
            {
                numbers200_399++;
            }
            else if (model.Number >= 400 && model.Number <= 599)
            {
                numbers400_599++;
            }
            else if (model.Number >= 600 && model.Number <= 799)
            {
                numbers600_799++;
            }
            else if(model.Number >= 800)
            {
                numbersInMoreThen800++;
            }
        }
        public double Procent1(HistogramaModel model)
        {
            model.P1 = numbersInLessThen200 / model.N * 100;
            Math.Round(model.P1, 2);
            return model.P1;
        }
        public double Procent2(HistogramaModel model)
        {
            model.P2 = numbers200_399 / model.N * 100;
            Math.Round(model.P2, 2);
            return model.P2;
        }
        public double Procent3(HistogramaModel model)
        {
            model.P3 = numbers400_599 / model.N * 100;
            Math.Round(model.P3, 2);
            return model.P3;
        }
        public double Procent4(HistogramaModel model)
        {
            model.P4 = numbers600_799 / model.N * 100;
            Math.Round(model.P4, 2);
            return model.P4;
        }
        public double Procent5(HistogramaModel model)
        {
            model.P5 = numbersInMoreThen800 / model.N * 100;
            Math.Round(model.P5, 2);
            return model.P5;
        }
    }
}
