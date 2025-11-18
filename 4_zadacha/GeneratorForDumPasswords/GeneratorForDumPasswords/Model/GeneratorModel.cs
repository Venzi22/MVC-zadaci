using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorForDumPasswords.Model
{
    internal class GeneratorModel
    {
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        private string letter;
        public string Letter
        {
            get { return letter; }
            set { letter = value; }
        }

        public GeneratorModel(int number, string later)
        {
            Number = number;
            Letter = later;
        }
    }
}
