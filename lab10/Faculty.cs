using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Faculty
    {
        protected string name;
        protected List<Student> facultyStudents;

        public Faculty(string name, List<Student> facultyStudents)
        {
            if (name != null && name.StartsWith("Ф")) this.name = name;
            else this.name = "ФАК";
            
            if (facultyStudents != null) this.facultyStudents = facultyStudents;
            else this.facultyStudents = new List<Student>();
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null && value.StartsWith("Ф")) name = value;
            }
        }
        public List<Student> FacultyStudents
        {
            get
            {
                return facultyStudents;
            }
            set
            {
                if (value != null) facultyStudents = value;
            }
        }
        public void AddStudent(Student student)
        {
            if (student != null) facultyStudents.Add(student);
        }
        public bool RemoveStudent(Student student)
        {
            if (student != null) return facultyStudents.Remove(student);
            return false;
        }
    }
}