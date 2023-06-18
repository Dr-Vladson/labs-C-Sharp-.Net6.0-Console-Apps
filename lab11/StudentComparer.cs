using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class StudentComparer : Comparer<Student>
    {
        public override int Compare(Student? student1, Student? student2)
        {
            if (student1 == null && student2 == null) return 0;
            if (student2 == null) return 1;
            if (student1 == null) return -1;

            return student1.CompareTo(student2);
        }
    }
}
