using System;
using System.Collections;

namespace ArraryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组三大问题
            //1、支持动态扩容
            //2、实现一个大小固定的有序数组，支持动态增删改操作
            ArrayList arrayList = new ArrayList();
            arrayList[0] = 1;
            arrayList[1] = 2;
            arrayList[2] = 3;
            arrayList[3] = 4;
            foreach(var i in arrayList)
            {
                Console.WriteLine(i);
            }


            //ResizeArray<int> resizeArray = new ResizeArray<int>();
            //resizeArray.AddItem(1);
            //resizeArray.AddItem(2);
            //resizeArray.AddItem(3);
            //resizeArray.AddItem(4);
            //resizeArray.AddItem(5);
            //resizeArray.AddItem(6);
            //resizeArray.AddItem(7);
            //resizeArray.AddItem(8);
            //resizeArray.AddItem(9);
            //for (var t = 0; t < resizeArray.Length; t++)
            //{
            //    Console.WriteLine();
            //}
            Console.ReadKey();

        }
    }
}
