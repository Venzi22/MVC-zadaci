using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using Exam.Service;

namespace Exam.Model
{
    internal class ExamModel
    {
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private int hrOfExam;
        public int HrOfExam
        {
            get { return hrOfExam; }
            set { hrOfExam = value; }
        }

        private int minOfExam;
        public int MinOfExam
        {
            get { return minOfExam; }
            set {  minOfExam = value; }
        }

        private int hrAraived;
        public int HrAraived
        {
            get { return hrAraived; }
            set { hrAraived = value; }
        }

        private int minAraived;
        public int MinAraived
        {
            get { return minAraived; }
            set { minAraived = value; }
        }

        private int minLateOREarly;
        public int MinLateOREarly
        {
            get { return minLateOREarly; }
            set { minLateOREarly = value; }
        }

        private int hrLateOREarly;
        public int HrLateOREarly
        {
            get { return hrLateOREarly; }
            set { hrLateOREarly = value; }
        }

        public ExamModel(string status, int hrOfExam, int minOfExam, int hrAraived, int minAraived, int minLateOREarly, int hrLateOREarly)
        {
            Status = status;
            HrOfExam = hrOfExam;
            MinOfExam = minOfExam;
            HrAraived = hrAraived;
            MinAraived = minAraived;
            MinLateOREarly = minLateOREarly;
            HrLateOREarly = hrLateOREarly;
        }
    }
}
