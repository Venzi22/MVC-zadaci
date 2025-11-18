using GeneratorForDumPasswords.Controler;
using GeneratorForDumPasswords.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorForDumPasswords.View
{
    internal class GeneratorView
    {
        public int number;
        public string later;

        private GeneratorControler _controler;
        public GeneratorView(GeneratorControler controler)
        {
            _controler = controler;
        }

        public void View()
        {
            number = int.Parse(Console.ReadLine());
            later = Console.ReadLine();
            var model = new GeneratorModel(number,later);
        }
    }
}
