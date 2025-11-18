using GeneratorForDumPasswords.Model;
using GeneratorForDumPasswords.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorForDumPasswords.Controler
{
    internal class GeneratorControler
    {
        private GeneratorService _service;

        public GeneratorControler(GeneratorService service)
        {
            _service = service;
        }

        public void Calculate(GeneratorModel model)
        {
            _service.Create(model);
        }
    }
}
