using Adventure.Controler;
using Adventure.Service;
using Adventure.View;

namespace Adventure;

internal class Program
{
    static void Main()
    {
        AdventureService service = new AdventureService();
        AdventureConroler conroler = new AdventureConroler(service);
        AdventureView view = new AdventureView(conroler);
        View.View();
        
    }
}
