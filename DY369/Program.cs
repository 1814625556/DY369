using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY369
{
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 改变结构体

            Books Book1;
            Book1.title = "C Programming";
            Book1.author = "Nuha Ali";
            Book1.subject = "C Programming Tutorial";
            Book1.book_id = 6495407;

            ChangeBooks(Book1);

            #endregion

            var str = "xxx";
            ChangeStr(str);
            Console.WriteLine(str);

            int i = 0;
            ChangeI(i);
            Console.WriteLine(i);

            var list = new int[]
            {
                7,8,9,10,1,2,5,6,13,15
            };

            ChangeArray(list);
            Console.WriteLine(list.ToString());


            var newArray = Sorting.MergeSort(list,0,list.Length-1);
            Console.ReadKey();
        }

        static void ChangeBooks(Books book)
        {
            book.author = "chenchang";
        }

        /// <summary>
        /// 泛型约束
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        static void ChangeStruct<T>(T t) where T:struct 
        {
            
        }

        static void ChangeStr(string str)
        {
            str = "369";
        }

        static void ChangeI(int i)
        {
            i = 369;
        }

        /// <summary>
        /// array即使元素是值类型，经过之后也会发生改变
        /// </summary>
        /// <param name="array"></param>
        static void ChangeArray(int[] array)
        {
            array[0] = 369;
            array[1] = 3369;
        }


        static void FindPairTwo(int[] array, int sum)
        {
            //快速排序
            QuickSort(ref array, 0, array.Length - 1);
            //所有小于sum的数据集合
            var newArray = array.Where(i => i < sum).ToArray();

            //遍历该集合
            var length = newArray.Length;
            var begin = 0;
            var end = length - 1;

            while (begin < end)
            {
                if (array[begin] + array[end] > sum)
                {
                    end--;
                }
                if (array[begin] + array[end] < sum)
                {
                    begin++;
                }
                if (array[begin] + array[end] == sum)
                {
                    Console.WriteLine($"这是一种组合：index:{begin},value:{newArray[begin]} -- index:{end}:value:{newArray[end]}");
                    begin++;
                    end--;
                }
            }
        }

        /// <summary>
        /// O(nlogn 复杂度)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
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
                QuickSort(ref nums, left, i);
                QuickSort(ref nums, i + 1, right);
            }
        }

        //first： 先对list进行排序 O(NLogN)-- 空间复杂度就上来了~
        //second: sum 一次遍历找到 index 最小—+最大的 O(N)

        static void FindPair(List<int> list, int sum)
        {
            var zuheList = new List<string>();
            for (var i = 0; i < list.Count-1; i++)
            {
                for (var j = i + 1; j < list.Count; j++)
                {
                    if (list[i] + list[j] == sum)
                    {
                        // 这里返回~
                        zuheList.Add($"这是一种组合：index:{i},value:{list[i]} -- index:{j}:value:{list[j]}");
                    }
                }
            }

            //打印出来所有组合：
            foreach (var zuhe in zuheList)
            {
                Console.WriteLine(zuhe);   
            }

        }

        

        static void bsf()
        {
            var a = new AdjacencyListBSF<string>();
            a.AddVertex("V1");
            a.AddVertex("V2");
            a.AddVertex("V3");
            a.AddVertex("V4");
            a.AddVertex("V5");
            a.AddVertex("V6");
            a.AddVertex("V7");
            a.AddVertex("V8");
            a.AddVertex("V9");
            a.AddVertex("V10");
            a.AddEdge("V1", "V2");
            a.AddEdge("V1", "V3");
            a.AddEdge("V2", "V4");
            a.AddEdge("V2", "V5");
            a.AddEdge("V3", "V6");
            a.AddEdge("V3", "V7");
            a.AddEdge("V4", "V8");
            a.AddEdge("V5", "V8");
            a.AddEdge("V6", "V8");
            a.AddEdge("V7", "V8");
            a.BFSTraverse(); //广度优先搜索遍历
        }

        class Student
        {
            public string Name { get; set; }
        }
    }
}
