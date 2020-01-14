using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DY369.leetcode
{
    public class ThreadFoo
    {
        private string str = "";
        public void First(Action printFirst)
        {
            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();
            str = "1";
        }

        public void Second(Action printSecond)
        {
            while (str != "1")
            {
                Thread.Sleep(5);
            }
            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();
            str = "2";
        }

        public void Third(Action printThird)
        {
            while (str != "2")
            {
                Thread.Sleep(5);
            }
            // printThird() outputs "third". Do not change or remove this line.
            printThird();
        }
    }
}
