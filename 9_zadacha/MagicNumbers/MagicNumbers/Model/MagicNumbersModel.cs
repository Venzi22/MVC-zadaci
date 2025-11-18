using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers.Model;

internal class MagicNumbersModel
{
    private int number;
    public int MagicNumber
    {
        get { return number; }
        set { number = value; }
    }
    private List<int> magicDigits;
    public List<int> MagicDigits
    {
        get { return magicDigits; }
        set { magicDigits = value; }
    }

    public MagicNumbersModel(int number, List<int> magicDigits)
    {
        MagicNumber = number;
        MagicDigits = magicDigits;
    }
}
