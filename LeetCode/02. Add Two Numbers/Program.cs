using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "ee";
            string result = (str.FirstOrDefault(ch => str.IndexOf(ch) == str.LastIndexOf(ch))).ToString();
            if (result == "")
            {
                result = "-1";
            }
            int r = int.Parse(result);
            return r;
        }
    }
}
