using System;
using System.Collections.Generic;
using System.Text;

namespace StackExample
{
    /// <summary>
    /// 可以动态调整大小的栈
    /// </summary>
    public class ResizeStack<T>
    {
        //
        private int _defaultSiez = 4;
        private T[] _item;
        private int _currentIndex;

        /// <summary>
        /// 不指定大小
        /// </summary>
        public ResizeStack()
        {
            _item = new T[_defaultSiez];
            _currentIndex = 0;
        }

        /// <summary>
        /// 指定大小
        /// </summary>
        /// <param name="n"></param>
        public ResizeStack(int n)
        {
            _item = new T[n];
            _currentIndex = 0;
        }


        public void Push(T t)
        {
            if (_currentIndex >= this._item.Length / 2)
            {
                var arr = new T[this._item.Length * 2];
                _item.CopyTo(arr,0);
                _item = arr;
            }
            _item[_currentIndex] = t;
            _currentIndex++;
        }

        public T Pop()
        {
            var value = default(T);
            if (_currentIndex == 0)
            {
                return value;
            }
             value=_item[_currentIndex - 1];
             _item[_currentIndex-1]=default(T);
            _currentIndex--;
            return value;
        }

        public int Count => this._currentIndex+1;




    }
}
