using System;
using System.Collections.Generic;
using System.Text;

namespace StackExample
{
    /// <summary>
    /// 节点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public T Item { get; set; }

        public Node<T> Next { get; set; }

        public Node(T item)
        {
            this.Item = item;
        }

        public Node(){

        }
    }


    /// <summary>
    /// 链式栈的实现
    /// </summary>
    public  class LinkListStack<T>
    {
        private Node<T> first;
        private int index;

        public LinkListStack()
        {
            this.first = null;
            this.index = 0;
        }

        public void Push(T item)
        {
            Node<T> oldNode = first;
            first = new Node<T>();
            first.Item = item;
            first.Next = oldNode;
            index++;
        }

        public T Pop()
        {
            T item = first.Item;
            first = first.Next;
            index--;
            return item;
        }

    }
}
