using System;
using System.Collections.Generic;
using System.Text;

namespace StackExample
{
    /// <summary>
    /// 顺序栈
    /// </summary>
    public class ArrayStack<T>
    {
        private int _currentIndex;
        private T[] _item;
        public int Count { get; set; }

        public ArrayStack(int n)
        {
            _item = new T[n];
            this.Count = n;
            _currentIndex = 0;
        }

        public void Push(T item)
        {
            _item[_currentIndex] = item;
            _currentIndex++;
            this.Count++;
        }

        public T Pop()
        {
            if (_currentIndex == 0)
            {
                return default(T);
            }
            var item = _item[_currentIndex - 1];
            _currentIndex--;
            _item[_currentIndex] = default(T);
            this.Count--;
            return item;
        }
    }
}
