using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY369.leetcode
{
    public class MinStack
    {
        public MinStack()
        {
            normalStack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int x)
        {
            normalStack.Push(x);
            int min;
            if (!minStack.Any() || minStack.Peek()>x)
            {
                min = x;
            }
            else
            {
                min = minStack.Peek();
            }
            minStack.Push(min);
        }

        public void Pop()
        {
            normalStack.Pop();
            minStack.Pop();
        }

        public int Top()
        {
            return normalStack.Peek();
        }

        public int GetMin()
        {
            return minStack.Peek();
        }
        private Stack<int> normalStack { get; set; }
        private Stack<int> minStack { get; set; }
    }
}
