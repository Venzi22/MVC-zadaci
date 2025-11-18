using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool.View;
using Pool.Service;
using Pool.Model;

namespace Pool.Controler
{
    internal class PoolControler
    {
        private PoolService _poolService;

        public PoolControler(PoolService poolService)
        {
            _poolService = poolService;
        }

        public void CalPool(PoolModel model)
        {
            _poolService.Cal(model);
        }
    }
}
