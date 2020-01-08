using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY369.leetcode
{
    public class DeleteNum
    {
        public static int LastRemaining(int n)
        {
            if (n <= 0) return 0;
            var list = new List<int>();
            for (var i = 1; i <= n; i++)
            {
                list.Add(i);
            }
            if (n == 1) return list[0];
            do
            {
                for (var i = 0; i < list.Count; i = i + 2)
                {
                    list[i] = 0;
                }
                list = list.Where(i => i > 0).ToList();
                if (list.Count > 1)
                {
                    for (var i = list.Count - 1; i >= 0; i = i - 2)
                    {
                        list[i] = 0;
                    }
                    list = list.Where(i => i > 0).ToList();
                }
            } while (list.Count > 1);
            return list[0];
        }

        public static int LastRemaining2(int n)
        {
            if (n <= 0) return 0;
            var list = new List<int>();
            for (var i = 1; i <= n; i++)
            {
                list.Add(i);
            }
            if (n == 1) return list[0];
            do
            {
                for (var i = 0; i < list.Count; i = i + 2)
                {
                    list[i] = 0;
                }
                list = list.Where(i => i > 0).ToList();
                if (list.Count > 1)
                {
                    for (var i = list.Count - 1; i >= 0; i = i - 2)
                    {
                        list[i] = 0;
                    }
                    list = list.Where(i => i > 0).ToList();
                }
            } while (list.Count > 1);
            return list[0];
        }

        /// <summary>
        /// 数学归纳法
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int lastRemaining(int n)
        {
            if (n == 1)
                return 1;
            if (n <= 5)
                return 2;
            if (n % 2 != 0)
                n -= 1;
            if (n % 4 != 0)
                return 4 * lastRemaining(n / 4);
            else
                return 4 * lastRemaining(n / 4) - 2;
        }
    }
}
