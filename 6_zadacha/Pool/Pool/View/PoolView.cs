using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool.Controler;
using Pool.Model;

namespace Pool.View
{
    internal class PoolView
    {
        public int pool;
        public int pipe1;
        public int pipe2;
        public double hour;
        public int poolPrc;
        public int pripe1Prc;
        public int pripe2Prc;
        public int overflow = 0;

        private PoolControler _controler;

        public PoolView(PoolControler controler)
        { 
            _controler = controler;
        }
        public void View()
        {
            pool = int.Parse(Console.ReadLine());
            pipe1 = int.Parse(Console.ReadLine());
            pipe2 = int.Parse(Console.ReadLine());
            hour = int.Parse(Console.ReadLine());
            var model = new PoolModel(pool,pipe1,pipe2,hour,poolPrc,pripe1Prc,pripe2Prc,overflow);
            _controler.CalPool(model);
            Console.WriteLine(model.Overflow);
            Console.WriteLine($"The pool is: {model.PoolPrc}%!Pipe 1 is {model.Pipe1Prc}% pipe 2 is {model.Pipe2Prc}");
        }
    }
}
