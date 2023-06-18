using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Student : IComparable<Student>
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
        }
        public Student ChangeName (string name)
        {
            if (!(name == null || name.Contains(" "))) return new Student(name, surname, reportCardNumber, averageMark);
            return new Student("Вася", surname, reportCardNumber, averageMark);
        }
        public string Surname
        {
            get
            {
                return surname;
            }
        }
        public Student ChangeSurname(string surname)
        {
            if (!(surname == null || surname.Contains(" "))) return new Student(name, surname, reportCardNumber, averageMark);
            return new Student(name, "Пупкін", reportCardNumber, averageMark);
        }
        public int ReportCardNumber
        {
            get
            {
                return reportCardNumber;
            }
        }
        public Student ChangeReportCardNumber(int reportCardNumber)
        {
            if (!(reportCardNumber <= 0)) return new Student(name, surname, reportCardNumber, averageMark);
            return new Student(name, surname, -1, averageMark);
        }
        public double AverageMark
        {
            get
            {
                return averageMark;
            }
        }
        public Student ChangeAverageMark(double averageMark)
        {
            if (!(averageMark > 100 || averageMark < 60)) return new Student(name, surname, reportCardNumber, averageMark);
            return new Student(name, surname, reportCardNumber, 60);
        }
        public int CompareTo (Student? another)
        {
            if (another == null) return -1;

            if (this.AverageMark.CompareTo(another.AverageMark) != 0)
            {
                return -(this.AverageMark.CompareTo(another.AverageMark));
            }
            if (this.Surname.CompareTo(another.Surname) != 0)
            {
                return this.Surname.CompareTo(another.Surname);
            }
            if (this.Name.CompareTo(another.Name) != 0)
            {
                return this.Name.CompareTo(another.Name);
            }
            if (this.ReportCardNumber.CompareTo(another.ReportCardNumber) != 0)
            {
                return -(this.ReportCardNumber.CompareTo(another.ReportCardNumber));
            }
            

            return 0;
        }
    }
}

