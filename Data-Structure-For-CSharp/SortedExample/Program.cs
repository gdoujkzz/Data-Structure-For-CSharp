using System;
using System.Diagnostics;

namespace SortedExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var res=SortHelper.BubbleSort(arr);
            sw.Stop();
            foreach(var i in res)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
