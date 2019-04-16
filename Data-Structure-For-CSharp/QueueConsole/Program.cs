using System;
using System.Collections;

namespace QueueExample
{
    class Program
    {

        static void Main(string[] args)
        {
            ArrayQueue<int> arrayQueue = new ArrayQueue<int>(10);
            Console.WriteLine("请输入操作选择:1 入队,2 出队,3 退出");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("目前队列元素为");
                    for (var i = 0; i < arrayQueue.Count; i++)
                    {
                        Console.Write(arrayQueue.DeQueue() + "\t");
                    }
                    Console.WriteLine("请输入要入队元素:");
                    int value = Convert.ToInt32(Console.ReadLine());

                    break;
                case 2:

                    break;
                case 3:

                    break;
            }
            arrayQueue.EnQueue(10);
            arrayQueue.DeQueue();
            arrayQueue.EnQueue(11);
            arrayQueue.EnQueue(12);
            arrayQueue.EnQueue(13);
            arrayQueue.EnQueue(14);
            arrayQueue.DeQueue();
            arrayQueue.DeQueue();
            Console.WriteLine("测试队列");
            Console.ReadKey();

        }
    }
}
