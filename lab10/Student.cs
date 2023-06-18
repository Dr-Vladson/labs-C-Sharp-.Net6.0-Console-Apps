using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Student
    {
        protected string name;
        protected string surname;
        protected int reportCardNumber;
        protected double averageMark;
        public Student(string name, string surname, int reportCardNumber, double averageMark)
        {
            if (name == null || name.Contains(" ")) this.name = "Вася";
            else this.name = name;

            if (surname == null || surname.Contains(" ")) this.surname = "Пупкін";
            else this.surname = surname;

            if (reportCardNumber <= 0) this.reportCardNumber = -1;
            else this.reportCardNumber = reportCardNumber;

            if (averageMark > 100 || averageMark < 60) this.averageMark = 60;
            else this.averageMark = averageMark;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!(value == null || value.Contains(" "))) name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (!(value == null || value.Contains(" "))) surname = value;
            }
        }
        public int ReportCardName
        {
            get
            {
                return reportCardNumber;
            }
            set
            {
                if (!(value <= 0)) reportCardNumber = value;
            }
        }
        public double AverageMark
        {
            get
            {
                return averageMark;
            }
            set
            {
                if (!(value > 100 || value < 60)) averageMark = value;
            }
        }
    }
}

