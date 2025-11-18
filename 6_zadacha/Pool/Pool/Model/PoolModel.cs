using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool.Service;

namespace Pool.Model
{
    internal class PoolModel
    {
        private int pool;
        public int Pool
        {
            get { return pool; }
            set { pool = value; }
        }
        private int pipe1;
        public int Pipe1
        {
            get { return pipe1;}
            set { pipe1 = value; }
        }
        private int pipe2;
        public int Pipe2
        {
            get { return pipe2;}
            set { pipe2 = value; }
        }
        private double hour;
        public double Hour
        {
            get { return hour; }
            set { hour = value; }
        }
        private int poolPrc;
        public int PoolPrc
        {
            get { return poolPrc; }
            set { poolPrc = value; }
        }
        private int pipe1Prc;
        public int Pipe1Prc
        {
            get { return pipe1Prc; }
            set { pipe1Prc = value; }
        }
        private int pipe2Prc;
        public int Pipe2Prc
        {
            get { return pipe2Prc; }
            set { pipe2Prc = value; }
        }
        private int overflow;
        public int Overflow
        {
            get { return overflow; }
            set { overflow = value; }
        }

        public PoolModel(int pool, int pipe1, int pipe2, double hour, int poolPrc,int pipe1Prc,int pipe2Prc, int overflow)
        {
            Pool = pool;
            Pipe1 = pipe1;
            Pipe2 = pipe2;
            Hour = hour;
            PoolPrc = poolPrc;
            Pipe1Prc = pipe1Prc;
            Pipe2Prc = pipe2;
            Overflow = overflow;
        }
    }
}
