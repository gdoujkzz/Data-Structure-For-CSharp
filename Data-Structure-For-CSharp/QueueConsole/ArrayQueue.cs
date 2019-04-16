using System;
using System.Collections.Generic;
using System.Text;

namespace QueueExample
{
    /// <summary>
    /// 顺序队列
    /// </summary>
    public class ArrayQueue<T>
    {
        //顺序队列
        private T[] _item;
         
        private int _head = 0;

        private int _tail = 0;

        public int Count = 0;


        public ArrayQueue(int capacity)
        {
            _item = new T[capacity];
            Count = capacity;
        }

        //入队 出队

        public void EnQueue(T item)
        {
            _item[_tail] = item;
            _tail++;
        }

        public T DeQueue()
        {
            if (_head == _tail)
            {
                return default(T);
            }
            var item = _item[_head];
            //这里可能会出现数据搬迁
            _head++;
            return item;
        }
        

    }
}
