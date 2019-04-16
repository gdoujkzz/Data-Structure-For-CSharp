using System;
using System.Collections.Generic;
using System.Text;

namespace SortedExample
{
    public class SortHelper
    {

        #region 冒泡排序版本1
        public static int[] BubbleSort(int[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        #endregion

        //改进做法一，上面是简单的从小到大排序，但是客户端想指定排序的方向，该如何是好呢
        #region  为了迎合客户需求所做的改进。
        public static int[] BubbleSort2(int[] arr, bool isAsc = true)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (isAsc)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            var temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                    else
                    {
                        if (arr[j] < arr[j + 1])
                        {
                            var temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
            }
            return arr;
        }
        #endregion

        //改进做法二，提高性能。
        public static int[] BubbleSort3(int[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                bool swapFlag = false;
                for (var j = 0; j < arr.Length - 1 - i; j++)
                {
                        if (arr[j] > arr[j + 1])
                        {
                            var temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                            swapFlag = true;
                        }
                }
                if (!swapFlag)
                {
                    break;
                }
            }
            return arr;
        }

    }
}
