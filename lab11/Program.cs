using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty fact = new Faculty("ФАКТ", new List<Student>()
            {
                new Student ("Дублiкат", "Дублiкатович", 100,100),
                new Student ("Iгор", "Адропов", 101,85),
                new Student ("Iгор", "Васильок", 102,85),
                new Student ("Дублiкат", "Дублiкатович", 100,100),
                new Student ("Володимир", "Швед", 103,85),
                new Student ("Антон", "Брат", 104,70),
                new Student ("Андрiй", "Брат", 105,70),
                new Student ("Антонiо", "Брат", 106,70),
                new Student ("Дублiкат", "Дублiкатович", 100,100),
            });
            Faculty fict = new Faculty("ФМПК", new List<Student>()
            {
                new Student ("Валерiй", "Гостровуменко", 1,99.99),
                new Student ("Василь", "Адропов", 2,64),
                new Student ("Iгор", "Васильок", 6,95),
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
                new Student ("Марiя", "Асилькевич", 8,100),
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

            Institute kpi = new Institute("KPI", new List<Faculty>() {fact,fict, fbmi, fl });

            foreach (Faculty faculty in kpi.InstituteFaculties)
            {
                Console.WriteLine(faculty.Name + " з населенням " + faculty.FacultyStudents.Count);
                foreach (Student student in faculty.FacultyStudents)
                {
                    Console.WriteLine("\t" + student.Surname + " " + student.Name + " з балом - " + student.AverageMark + " i номером залiковки : " + student.ReportCardNumber);
                }
            }

            int studentAmount = kpi.countStudentsAmount();
            Console.WriteLine("Кiлькiсть студентiв - " + studentAmount + "\n");

            Faculty? biggestFaculty = kpi.findBiggestFaculty();
            Console.WriteLine("Найбiльший факультет - " + biggestFaculty?.Name + "\n");

            SortedSet<Student> bestStudents = kpi.findBestStudents();
            Console.WriteLine("Множина студентiв iз балом 95+");
            foreach (Student student in bestStudents)
            {
                Console.WriteLine(student.Surname + " " + student.Name + " з середнiм балом " + student.AverageMark);
            }
        }
    }
}
