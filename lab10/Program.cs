using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty fict = new Faculty("ФІОТ", new List<Student>()
            {
                new Student ("Валерiй", "Гостровуменко", 1,99.99),
                new Student ("Василь", "Адропов", 2,64),
                new Student ("Антон", "Мирний", 3,85),
                new Student ("Володимир", "Гук", 4,70),
                new Student ("Панас", "Хук", 5,70),
                new Student ("Петро", "Ашкiн", 6,95),
            });
            Faculty fbmi = new Faculty("ФБМI", new List<Student>()
            {
                new Student ("Олександра", "Юрко", 12,89),
                new Student ("Василь", "Пономар", 13,67.8),
                new Student ("Юрiй", "Жук", 14,85),
                new Student ("Валентина", "Антошкiна", 15,79),
                new Student ("Артем", "Заїда", 16,95.5),
                new Student ("Олексiй", "Морозенко", 17,97.8),
                new Student ("Марiя", "Дорошенко", 18,61),
                new Student ("Сергiй", "Мiрошниченко", 19,71.5),
                new Student ("Марiя", "Василькевич", 8,100),
                new Student ("Сергiй", "Мiрошниченко", 19,71.5),
                new Student ("Марiя", "Олександров", 7,78),
            });
            Faculty fl = new Faculty("ФЛ", new List<Student>()
            {
                new Student ("Петро", "Юрчук", 22,88),
                new Student ("Валентин", "Хвеська", 23,96),
                new Student ("Юрiй", "Пiддубний", 24,85.1),
                new Student ("Артем", "Забарний", 25,72.78),
                new Student ("Антон", "Мосейчук", 26,78),
                new Student ("Олександр", "Мороз", 27,96.91),
                new Student ("Юлiя", "Цезарь", 28,90.6),
                new Student ("Василiса", "Порошенко", 29,65.6),
            });

            Institute kpi = new Institute("KPI", new List<Faculty>() {fict, fbmi, fl});

            int studentAmount = kpi.countStudentsAmount();
            Console.WriteLine("Кiлькiсть студентiв - " + studentAmount + "\n");

            Faculty biggestFaculty = kpi.findBiggestFaculty();
            Console.WriteLine("Найбiльший факультет - " + biggestFaculty.Name + "\n");

            List<Student> bestStudents = kpi.findBestStudents();
            Console.WriteLine("Список студентiв iз балом 95+");
            foreach(Student student in bestStudents)
            {
                Console.WriteLine(student.Name + " " + student.Surname + " з середнiм балом " + student.AverageMark);
            }
        }
    }
}
