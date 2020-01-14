using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY369.leetcode
{
    public class CanWinNimxx
    {
        public bool CanWinNim(int n)
        {
            if (n < 4) return true;
            return n%4 != 0;
        }

        public static int CountBinarySubstrings(string s)
        {
            if (s.Length < 2) return 0;
            var sum = 0;
            for (var i = 0; i < s.Length-1; i++)
            {
                if (s[i] != s[i + 1])
                {
                    sum++;
                    continue;
                }
                for (var j = 1; j < (s.Length - i); j++)
                {
                    if (s[i] != s[i + j])
                    {
                        for (var c = 1; c < j; c++)
                        {
                            if (i + j + c > s.Length - 1) break;
                            if (s[i] == s[i + j + c]) break;
                            if (c == j-1) sum++;
                        }
                        break;
                    }
                }
            }
            return sum;
        }

        public static bool IsUgly(int num)
        {
            if (num < 1) return false;
            while (true)
            {
                if (num == 1) return true;
                if (num % 2 == 0)
                {
                    num = num / 2;
                    continue;
                }
                else if (num % 3 == 0)
                {
                    num = num / 3;
                    continue;
                }
                else if (num % 5 == 0)
                {
                    num = num / 5;
                    continue;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
