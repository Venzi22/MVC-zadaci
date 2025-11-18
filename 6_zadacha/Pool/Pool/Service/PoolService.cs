using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool.Controler;
using Pool.Model;

namespace Pool.Service
{
    internal class PoolService
    {
        private int pipe1Progers;
        private int pipe2Progers;
        private int poolProgrers; 
        public void Cal(PoolModel model)
        {
            pipe1Progers = model.Pipe1 * Convert.ToInt32(model.Hour);//Най-вероятно проблема е тук с конвертирането
            pipe2Progers = model.Pipe2 * Convert.ToInt32(model.Hour);
            poolProgrers = pipe1Progers + pipe2Progers;
            if (poolProgrers <= model.Pool) //IDK why but it does not works
            {
                model.PoolPrc = poolProgrers / model.Pool * 100;
                model.Pipe1Prc = pipe1Progers/ model.Pool * 100;
                model.Pipe2Prc = pipe2Progers / model.Pool * 100;
            }
            else //Overflow works
            {
                model.Overflow = poolProgrers - model.Pool;
            }
        }
    }
}
