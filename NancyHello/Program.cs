using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;
using Nancy.Hosting.Self;

namespace NancyHello
{
    class Program
    {
        static void Main(string[] args)
        {
            NancyHost nancyHost = new NancyHost(new HostConfiguration
            {
                UrlReservations = new UrlReservations() { CreateAutomatically = true }
            }, new Uri("http://localhost:13002/"));
            nancyHost.Start();
            Console.WriteLine("Nancy now listening - navigate to http://localhost:13002/. Press 		enter to stop");
            Console.ReadKey();
            nancyHost.Stop();
            Console.WriteLine("finall...");
        }
    }
    public class HelloNancy : NancyModule
    {
        public HelloNancy()
        {
            Get("/hello", x => "Hello world");
        }
    }
}
