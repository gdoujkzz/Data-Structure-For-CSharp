using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArraryExample
{
    /// <summary>
    /// 动态可调整大小的数组
    /// </summary>
    public class ResizeArray<T>
    {
        private  int _defaultSize;
        private int _currentIndex;
        public int Length => this._currentIndex+1;
        public T[] arr ;

        public ResizeArray(){
            _defaultSize = 4;
            arr = new T[_defaultSize];
            _currentIndex = 0;
        }

        public ResizeArray(int size)
        {
            _defaultSize = size;
            arr = new T[_defaultSize];
            _currentIndex = 0;
        }
        //上面就是初始化的大小
        //支持动态扩容，缩容
        public void AddItem(T item)
        {
            arr[_currentIndex] = item;
            if (_currentIndex <= _defaultSize / 2)
            {
                //进行扩容
                _defaultSize = _defaultSize * 2;
                T[] tempArr = new T[_defaultSize*2];
                arr.CopyTo(tempArr, 0);
                arr = tempArr;
            }
            _currentIndex++;
        }

        /// <summary>
        /// 移除指定元素(默认删除最后一个元素）
        /// </summary>
        public void RemoveItem()
        {
            arr[_currentIndex - 1] = default(T);
            if(_currentIndex*2<= _defaultSize)
            {
                T[] tempArr = new T[_defaultSize /2];
                arr.CopyTo(tempArr, 0);
                arr = tempArr;
            }
            _currentIndex--;
        }
    }
}
