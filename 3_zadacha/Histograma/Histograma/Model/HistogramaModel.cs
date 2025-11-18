using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Histograma.Service;

namespace Histograma.Model
{
    internal class HistogramaModel
    {
        private double p1;
        public double P1
        { 
            get { return p1; } 
            set { p1 = value; } 
        }
        private double p2;
        public double P2
        {
            get { return p2; }
            set { p2 = value; }
        }
        private double p3;
        public double P3
        {
            get { return p3; }
            set { p3 = value; }
        }
        private double p4;
        public double P4
        {
            get { return p4; }
            set { p4 = value; }
        }

        private double p5;
        public double P5
        {
            get { return p5; }
            set { p5 = value; }
        }

        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        private int n;
        public int N
        {
            get { return n; }
            set { n = value; }
        }

        public HistogramaModel(double p1, double p2, double p3, double p4, double p5, int number, int n)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            P4 = p4;
            P5 = p5;
            Number = number;
            N = n;
        }
    }
}
