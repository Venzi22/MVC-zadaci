using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Division.Controler;
using Division.Model;

namespace Division.View;

internal class DivisionView
{
    public int n;
    public double p1;
    public double p2;
    public double p3;
    public int[] numbers;

    private DivisionControler _controler;

    public DivisionView(DivisionControler controler)
    {
        _controler = controler;
    }

    public void View()
    {
        n = int.Parse(Console.ReadLine());
        numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a nuber:");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        var model = new DivisionModel(n,p1,p2,p3,numbers);
        _controler.Cal(model);
        _controler.CalPrc(model);
        Console.WriteLine(model.P1);
        Console.WriteLine(model.P2);
        Console.WriteLine(model.P3);
    }
}
