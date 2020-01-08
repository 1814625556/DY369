using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY369.leetcode
{
    //给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。
    public class ReverseInt
    {
        public static int Reverse(int x)
        {
            var result = "";
            var str = x > 0 ? x.ToString() : x.ToString().Substring(1);
            var count = str.Length;
            for(var i=0;i<count;i++)
            {
                result += str[count - i - 1];
            }
            int rs = Convert.ToInt32(result);
            if ((rs > Math.Pow(2, 31) - 1) || (rs < (-1) * Math.Pow(2, 31)))
            {  //超过范围的返回0
                return 0;
            }
            if (x > 0) return rs;
            return (-1) * rs;
        }

        /// <summary>
        /// 通过~
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Reverse2(int x)
        {
            var temp = x;
            long rs = 0;
            if (x < 0) temp *= (-1);

            var count = temp.ToString().Length;
            while (count > 0)
            {
                var a = temp % 10;
                rs += (Int64)(a * Math.Pow(10, count - 1));
                count--;
                temp = temp / 10;
            }
            if ((rs > Math.Pow(2, 31) - 1) || (rs < (-1) * Math.Pow(2, 31)))
            {
                return 0;
            }
            if (x < 0) return (int)rs * (-1);
            return (int)rs;
        }
    }
}
