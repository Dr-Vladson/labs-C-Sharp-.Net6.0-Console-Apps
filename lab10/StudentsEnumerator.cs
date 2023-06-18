using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class StudentsEnumerator : IEnumerator
    {
        private List<Student> _students = new List<Student>();
        private int _position = -1;
        public StudentsEnumerator(List<Student> students) { if (students != null) this._students = students; }
        public object Current
        {
            get
            {
                if (_position == -1 || _position >= _students.Count) throw new ArgumentException();
                return _students[_position];
            }
        }
        public bool MoveNext()
        {
            if (_position < _students.Count - 1)
            {
                _position++;
                return true;
            }
            else return false;
        }
        public void Reset() => _position = -1;
    }
}
