using Pool.Controler;
using Pool.Service;
using Pool.View;

namespace Pool
{
    internal class Program
    {
        static void Main()
        {
            PoolService service = new PoolService();
            PoolControler controler = new PoolControler(service);
            PoolView view = new PoolView(controler);
            view.View();
        }
    }
}
