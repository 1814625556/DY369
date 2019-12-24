using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace NancyHttpServiceDemo
{
    public class HelloNancy : NancyModule
    {
        public HelloNancy()
        {
            Get("/hello", x => "Hello world");
        }
    }
}
