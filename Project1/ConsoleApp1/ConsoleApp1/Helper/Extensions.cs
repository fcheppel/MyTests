using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleApp1.Helper
{
    public static class Extensions
    {
        public static string GetDesc(this Enum value)
        {
            return value
                .GetType()
                .GetMember(value.ToString())
                .FirstOrDefault()?
                .GetCustomAttribute<DescriptionAttribute>()?
                .Description
                ?? value.ToString();
        }

        public static string ListToString<T>(this IEnumerable<T> l)
        {
            return l.Aggregate(new StringBuilder(), (c, n) => c.Append(string.IsNullOrEmpty(c.ToString()) ? "" : ",").Append(n)).ToString();
        }
    }
}
