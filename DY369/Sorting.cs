using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY369
{
    public class Sorting
    {
        
        /// <summary>
        /// 插入排序优化方案
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] InsertionSort(int[] array)
        {
            if (array == null || array.Length < 2)
                return array;
           
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i - 1;
                while (j >= 0)
                {
                    if (key > array[j])
                        break;

                    array[j + 1] = array[j];
                    j--;
                }
                array[j+1] = key;
            }

            return array;
        }

        /// <summary>
        /// 暴力美学，冒泡排序算法
        /// </summary>
        /// <param name="array"></param>
        public static int[] BubbleSort(int[] array)
        {
            if (array == null || array.Length < 2)
                return array;

            for (var i = array.Length; i > 0; i--)
            {
                for (var j = 0; j < i; j++)
                {
                    if (array[j] <= array[j + 1]) continue;

                    var temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                }
            }
            return array;
        }

        /// <summary>
        /// 选择排序
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] SelectSort(int[] array)
        {
            if (array == null || array.Length < 2)
                return array;
            for (var i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1) break;
                var minIndex = i;
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[minIndex] > array[j])
                    {
                        minIndex = j;
                    }
                }

                var temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
            return array;
        }

        //快速排序（目标数组，数组的起始位置，数组的结束位置）
        public static void QuickSort(ref int[] nums, int left, int right)
        {
            if (left < right)
            {
                var i = left;
                var j = right;
                var middle = nums[(left + right) / 2];
                while (true)
                {
                    while (i < j && nums[i] < middle) { i++; };
                    while (j > i && nums[j] > middle) { j--; };
                    if (i == j) break;
                    
                    //交换位置
                    nums[i] = nums[i] + nums[j];
                    nums[j] = nums[i] - nums[j];
                    nums[i] = nums[i] - nums[j];
                    if (nums[i] == nums[j]) j--;
                }
                QuickSort(ref  nums, left, i);
                QuickSort(ref  nums, i + 1, right);
            }
        }

        /// <summary>
        /// 计数排序，核心思想是 申请内存空间，然后依次放入
        /// </summary>
        /// <param name="array"></param>
        public static void CountingSort(int[] array)
        {
            if (array.Length == 0) return;
            int min = array[0];
            int max = min;
            foreach (int number in array)
            {
                if (number > max)
                {
                    max = number;
                }
                else if (number < min)
                {
                    min = number;
                }
            }

            //属组
            int[] counting = new int[max - min + 1];
            
            // value就是出现的次数
            for (int i = 0; i < array.Length; i++)
            {
                counting[array[i] - min] += 1;
            }
            int index = -1;
            for (int i = 0; i < counting.Length; i++)
            {
                for (int j = 0; j < counting[i]; j++)
                {
                    index++;
                    array[index] = i + min;
                }
            }
        }

    }
}
