using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Logic
{
    public class Processing
    {
        public decimal dec;

        public enum Oper
        {
            plus = 1,
            minus = 2,
            multiple = 3,
            devide = 4
        }

        public decimal? Test(Oper oper, decimal a, decimal b)
        {
            return oper switch
            {
                Oper.plus => a + b,
                Oper.minus => a - b,
                Oper.multiple => a * b,
                Oper.devide => b == 0 ? (decimal?)null : a / b,
                _ => null,
            };
        }
    }
}
