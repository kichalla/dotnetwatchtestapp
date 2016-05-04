using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var c = new ClassLibrary1.Class1();
            Console.WriteLine(c.GetGreeting());

            var loggerFactory = new LoggerFactory()
                .AddConsole();
            var logger = loggerFactory.CreateLogger<Program>();
            logger.LogInformation("A message from Program");
        }
    }
}
