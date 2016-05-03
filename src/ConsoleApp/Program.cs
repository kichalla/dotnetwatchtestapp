using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var c = new ClassLibrary1.Class1();
            Console.WriteLine(c.GetGreeting());
        }
    }
}
