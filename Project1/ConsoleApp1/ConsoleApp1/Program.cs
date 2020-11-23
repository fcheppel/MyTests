using ConsoleApp1.Logic;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<decimal> { 1, 2, 3, 3 };

            var proc = new Processing();

            Console.WriteLine("Starting!");

            Console.WriteLine("Count args: " + args.Length);

            Console.WriteLine("Count: "+list.Count);

            Console.WriteLine("Res: "+proc.Test());

            Console.ReadKey();
        }
    }
}
