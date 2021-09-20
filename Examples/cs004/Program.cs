using System;
using System.Collections.Generic;

namespace cs004
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            { "Searches","for","an","element", "that","matches","the","conditions"};

            // 使用 Lambda 匿名委派方法
            list.Sort((x1, x2) => { return x1.CompareTo(x2); });
            // 使用 Named 具名委派方法
            //list.Sort(StringSorting);
            foreach (var item in list)
            {
                Console.WriteLine($"{item} ");
            }
        }
        private static int StringSorting(string x1, string x2)
        {
            return x1.CompareTo(x2);
        }
    }
}
