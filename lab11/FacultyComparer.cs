using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class FacultyComparer : Comparer<Faculty>
    {
        public override int Compare(Faculty? fac1, Faculty? fac2)
        {
            if (fac1 == null && fac2 == null) return 0;
            if (fac2 == null) return 1;
            if (fac1 == null) return -1;

            return fac1.CompareTo(fac2);
        }
    }
}
