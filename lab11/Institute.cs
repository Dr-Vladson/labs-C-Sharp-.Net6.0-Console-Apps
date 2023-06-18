using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Institute
    {
        protected string name;
        protected SortedSet<Faculty> instituteFaculties;

        public Institute(string name, List<Faculty> instituteFaculties)
        {
            if (name != null) this.name = name;
            else this.name = "Деякий інститут";
            
            if (instituteFaculties != null) this.instituteFaculties = new SortedSet<Faculty>(instituteFaculties, new FacultyComparer());
            else this.instituteFaculties = new SortedSet<Faculty>(new FacultyComparer());
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null) name = value;
            }
        }
        public SortedSet<Faculty> InstituteFaculties
        {
            get
            {
                return instituteFaculties;
            }
            set
            {
                if (value != null) instituteFaculties = value;
            }
        }

        public int countStudentsAmount()
        {
            int studentsAmount = 0;
            foreach (Faculty faculty in instituteFaculties)
            {
                studentsAmount += faculty.FacultyStudents.Count;
            }
            return studentsAmount;
        }

        public Faculty? findBiggestFaculty()
        {
            return instituteFaculties.Min;
        }

        public SortedSet<Student> findBestStudents()
        {
            SortedSet<Student> bestStudents = new SortedSet<Student>(new StudentComparer());

            foreach (Faculty faculty in instituteFaculties)
            {
                foreach (Student student in faculty.FacultyStudents)
                {
                    if (student.AverageMark >= 95) bestStudents.Add(student);
                    else break;
                }
            }

            return bestStudents;
        }

        public void AddFaculty(Faculty faculty)
        {
            if (faculty != null) instituteFaculties.Add(faculty);
        }
        public bool RemoveFaculty(Faculty faculty)
        {
            if (faculty != null) return instituteFaculties.Remove(faculty);
            return false;
        }
    }
}
