using Shop.Controler;
using Shop.Model;
using Shop.Service;
using Shop.View;

namespace Shop
{
    internal class Program
    {
        static void Main()
        {
            ShopService service = new ShopService();
            ShopControler controler = new ShopControler(service);
            ShopView view = new ShopView(controler);
            view.View();
        }
    }
}
