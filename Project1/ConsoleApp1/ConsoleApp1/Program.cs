using ConsoleApp1.Logic;
using System;
using System.Collections.Generic;
using static ConsoleApp1.Logic.Processing;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<decimal> { 1, 2, 3, 3 };

            decimal a = 213.432M;
            decimal b = 254533.434532M;
            Oper oper = Oper.minus;

            var proc = new Processing();

            Console.WriteLine("Starting!");

            Console.WriteLine("Count args: " + args.Length);

            Console.WriteLine("Count: "+list.Count);

            Console.WriteLine("Res: " + proc.Test(oper, a, b));

            Console.ReadKey();
        }
    }
}
