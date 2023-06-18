using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Faculty : IComparable<Faculty>
    {
        protected string name;
        protected SortedSet<Student> facultyStudents;

        public Faculty(string name, IEnumerable <Student> facultyStudents)
        {
            if (name != null && name.StartsWith("Ф")) this.name = name;
            else this.name = "ФАК";
            
            if (facultyStudents != null) this.facultyStudents = new SortedSet<Student>(facultyStudents, new StudentComparer());
            else this.facultyStudents = new SortedSet<Student>(new StudentComparer());
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Faculty ChangeName(string name)
        {
            if (name != null && name.StartsWith("Ф")) return new Faculty(name, facultyStudents);
            return new Faculty("ФАК", facultyStudents);
        }
        public SortedSet<Student> FacultyStudents
        {
            get
            {
                return facultyStudents;
            }
        }
        public Faculty ChangeFacultyStudents(IEnumerable<Student> facultyStudents)
        {
            return new Faculty(name, facultyStudents);
        }
        public int CompareTo(Faculty? another)
        {
            if (another == null) return -1;

            if (this.FacultyStudents.Count.CompareTo(another.FacultyStudents.Count) != 0)
            {
                return -(this.FacultyStudents.Count.CompareTo(another.FacultyStudents.Count));
            }
            if (this.Name.CompareTo(another.Name) != 0)
            {
                return this.Name.CompareTo(another.Name);
            }

            return 0;
        }
    }
}