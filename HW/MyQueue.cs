using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public delegate void Msg(string message); //объявление делегата

    public class MyQueue<T>
    {
        private Element<T> _Head;
        private Element<T> _Tail;
        private int _Size;
        public Msg msg;
        public event Action<string> MyInfo; //Объявление события

        public MyQueue()
        {
            _Head = null;
            _Tail = null;
            _Size = 0;
            MyInfo?.Invoke("Создан объект класса");
        }

        public int Count()
        {
            return _Size;
            msg?.Invoke($"Размер {_Size}"); //вызов делегата с проверкой
            MyInfo?.Invoke("Запрошен размер очереди"); //вызов события с проверкой
        }

        public void Push(T value)
        {
            if(_Size == 0)
            {
                _Head = _Tail = new Element<T>(value);
            }else
            {
                Element<T> temp = new(value, _Head.GetNext());
                _Head.SetPrev(temp);
                _Head = temp;
            }
            _Size++;
            msg?.Invoke($"Добавлен {value}");
            MyInfo?.Invoke("Вызван метод Push");
        }

        public T Pop()
        {
            MyInfo?.Invoke("Вызван метод Pop");
            if (_Size == 0)
            {
                MyInfo?.Invoke("Метод Pop завершен с ошибкой");
                throw new Exception("Error: Queue is empty. Nothing to Pop");
            } 
            T result = _Tail.GetValue();
            _Tail = _Tail.GetPrev();
            if (_Size == 1)
            {
                msg?.Invoke($"Удален {_Head.GetValue()}");
                _Head = null;
                _Tail = null;
            }else
            {
                msg?.Invoke($"Удален {_Tail.GetValue()}");
                _Tail.DeleteNext();
            }

            _Size--;
            MyInfo?.Invoke("Метод Pop завершен успехом");
            return result;
        }
    }
}
