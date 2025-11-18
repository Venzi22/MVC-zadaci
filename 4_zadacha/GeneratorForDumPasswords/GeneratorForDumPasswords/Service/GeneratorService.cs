using GeneratorForDumPasswords.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorForDumPasswords.Service
{
    internal class GeneratorService
    {
        int firstNum;
        int secondNum;
        int thirdNum;
        int pastFirstNum =0;
        int pastSecondNum =0;
        int pastThirdNum =0;
        string firstLater;
        string secondLater;
        string pastFirstLater = "@";
        string pastSecondLater = "@";
        public void Create(GeneratorModel model)
        {
            if (model.Number != firstNum)
            {

            }

            pastFirstNum = firstNum;
            pastSecondNum = secondNum;
            pastThirdNum = thirdNum;
            pastFirstLater = firstLater;
            pastSecondLater = secondLater;
            
        }
    }
}
