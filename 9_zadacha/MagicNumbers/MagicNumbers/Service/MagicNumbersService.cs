using MagicNumbers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers.Service;

internal class MagicNumbersService
{
    public void Magic(MagicNumbersModel model)
    {
        for (int number = 111111; number <= 999999; number++)
        {
            int n = number;
            int d6 = n % 10; n /= 10;
            int d5 = n % 10; n /= 10;
            int d4 = n % 10; n /= 10;
            int d3 = n % 10; n /= 10;
            int d2 = n % 10; n /= 10;
            int d1 = n % 10;
            //Целта е да раздробим числотона отделни digits и да прави проверка кое число то 111111 до 99999 може да се добави | от caht ГПТ

            int result = d1 * d2 * d3 * d4 * d5 * d6;

            if (result == model.MagicNumber)
            {
                model.MagicDigits.Add(number);
            }
        }
    }
}
