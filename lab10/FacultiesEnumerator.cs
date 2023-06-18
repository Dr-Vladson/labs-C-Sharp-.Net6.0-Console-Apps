using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class FacultiesEnumerator : IEnumerator
    {
        private List <Faculty> _faculties = new List<Faculty>();
        private int _position = -1;
        public FacultiesEnumerator(List<Faculty> faculties) { if (faculties != null) this._faculties = faculties; }
        public object Current
        {
            get
            {
                if (_position == -1 || _position >= _faculties.Count) throw new ArgumentException();
                return _faculties[_position];
            }
        }
        public bool MoveNext()
        {
            if (_position < _faculties.Count - 1)
            {
                _position++;
                return true;
            }
            else return false;
        }
        public void Reset() => _position = -1;
    }
}
