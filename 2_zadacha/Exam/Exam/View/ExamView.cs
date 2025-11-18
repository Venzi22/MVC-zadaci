using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Controler;
using Exam.Service;

namespace Exam.View
{
    internal class ExamView
    {
        public string status;
        public int hrOfExam;
        public int minOfExam;
        public int hrAraived;
        public int minAraived;
        public int minLateOREarly;
        public int hrLateOREarly;

        private ExamControler Controler;
        public ExamView(ExamControler controler )
        {
            Controler = controler;
        }

        public void View()
        {
            hrOfExam = int.Parse(Console.ReadLine());
            minOfExam = int.Parse(Console.ReadLine());
            hrAraived = int.Parse(Console.ReadLine());
            minAraived = int.Parse(Console.ReadLine());
            var model = new Model.ExamModel(status, hrOfExam, minOfExam, hrAraived, minAraived, minLateOREarly, hrLateOREarly);
            var controler = Controler.ExamServiceCal(model);
            Console.WriteLine("You are " + model.Status);
            if(model.MinLateOREarly > 59)
            {
                model.HrLateOREarly += model.MinLateOREarly / 60;
                model.MinLateOREarly = model.MinLateOREarly - 60;
            }
            if (model.MinLateOREarly < 10)
            {
                Console.WriteLine(model.HrLateOREarly + ":0" + model.MinLateOREarly);
            }
            else
            {
                Console.WriteLine(model.HrLateOREarly + ":" + model.MinLateOREarly);
            } 
        }
    }
}
