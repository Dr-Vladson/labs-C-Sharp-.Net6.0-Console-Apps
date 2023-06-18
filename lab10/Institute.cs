using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Institute
    {
        protected string name;
        protected List<Faculty> instituteFaculties;

        public Institute(string name, List<Faculty> instituteFaculties)
        {
            if (name != null) this.name = name;
            else this.name = "Деякий інститут";
            
            if (instituteFaculties != null) this.instituteFaculties = instituteFaculties;
            else this.instituteFaculties = new List<Faculty>();
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
        public List<Faculty> InstituteFaculties
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
            FacultiesTypedEnumerator facultiesTypedEnumerator = new FacultiesTypedEnumerator(instituteFaculties);
            while (facultiesTypedEnumerator.MoveNext())
            {
                studentsAmount += facultiesTypedEnumerator.Current.FacultyStudents.Count;
            }
            return studentsAmount;
        }

        public Faculty findBiggestFaculty()
        {
            Faculty biggestFaculty = new Faculty("ФДефолт", new List<Student>());
            foreach (Faculty faculty in instituteFaculties)
            {
                if (faculty.FacultyStudents.Count > biggestFaculty.FacultyStudents.Count) biggestFaculty = faculty;
            }
            return biggestFaculty;
        }

        public List<Student> findBestStudents()
        {
            List<Student> bestStudents = new List<Student>();

            FacultiesEnumerator facultiesEnumerator = new FacultiesEnumerator(instituteFaculties);
            while (facultiesEnumerator.MoveNext())
            {
                StudentsEnumerator studentsEnumerator = new StudentsEnumerator(((Faculty)facultiesEnumerator.Current).FacultyStudents);
                while (studentsEnumerator.MoveNext())
                {
                    if (((Student)studentsEnumerator.Current).AverageMark >= 95) bestStudents.Add(((Student)studentsEnumerator.Current));
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
