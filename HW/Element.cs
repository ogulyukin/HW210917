using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Element<T>
    {
        private readonly T _Value;
        private Element<T> _Prev;
        private Element<T> _Next;

        public Element(T value)
        {
            _Value = value;
            _Next = null;
            _Prev = null;
        }

        public Element(T value, Element<T> next)
        {
            _Value = value;
            _Next = next;
        }

        public T GetValue()
        {
            return _Value;
        }

        public Element<T> GetPrev()
        {
            return _Prev;
        }

        public Element<T> GetNext()
        {
            return _Next;
        }

        public void SetPrev(Element<T> prev)
        {
            _Prev = prev;
        }

        public void DeleteNext()
        {
            _Next = null;
        }
    }
}
