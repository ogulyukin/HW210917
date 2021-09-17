using System;

namespace HW
{
    class Program
    {
        static void Main()
        {
            MyQueue<int> list = new();

            //list.msg = Console.WriteLine;
            list.MyInfo += Console.WriteLine;
            list.Push(5);
            list.Push(2);
            list.Pop();
        }
    }
}
