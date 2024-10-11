using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics04
{
    public class MyStack<T>
    {
        List<T> list;
        public int Count()
        {
            return list.Count;
        }
        public T Pop()
        {
            T element = list[list.Count-1];
            list.RemoveAt(list.Count-1);
            return element;
        }
        public void Push(T element)
        {
            list.Add(element);
        }
    }
}
