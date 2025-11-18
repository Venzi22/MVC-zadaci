using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division.Model;

internal class DivisionModel
{
    private int n;
    public int N
    {
        get { return n; }
        set { n = value; }
    }

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
    private int[] numbers;
    public int[] Numbers
    {
        get { return numbers; }
        set { numbers = value; }
    }
    public DivisionModel(int n, double p1, double p2, double p3, int[] numbers)
    {
        N = n;
        P1 = p1;
        P2 = p2;
        P3 = p3;
        Numbers = numbers;
    }
}
