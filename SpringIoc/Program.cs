﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Context;
using Spring.Context.Support;

namespace SpringIoc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test();
            IApplicationContext ctx = ContextRegistry.GetContext();

            var fruit = ctx.GetObject("fruit");

            Animals animal = ctx.GetObject("animal") as Animals;

            Console.ReadKey();
        }

        static void Test()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();

            Person person = ctx.GetObject("person") as Person;

            Console.WriteLine("BestFriends");
            foreach (Person friend in person.BestFriends)
            {
                Console.WriteLine(friend.Name);
            }
            Console.WriteLine();
            
            Console.WriteLine();

            Console.WriteLine("IList");
            foreach (var item in person.HappyYears)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("泛型Ilist<int>");
            foreach (int item in person.Years)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("IDictionary");
            foreach (DictionaryEntry item in person.HappyDic)
            {
                Console.WriteLine(item.Key + " 是 " + item.Value);
            }
            Console.WriteLine();

            Console.WriteLine("泛型IDictionary<string,object>");
            foreach (KeyValuePair<string, object> item in person.HappyTimes)
            {
                Console.WriteLine(item.Key + " 是 " + item.Value);
            }

            Console.ReadLine();
        }
    }
}
