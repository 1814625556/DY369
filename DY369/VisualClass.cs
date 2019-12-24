using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY369
{
    public class VisualClass
    {
        public virtual void Method1()
        {
            Console.WriteLine("I am a visual method");
        }
    }
    public class Dog : VisualClass
    {
        public void Method2()
        {
            Console.WriteLine("i am method2");
        }
    }
}
