using System;
using System.Collections.Generic;

namespace cs002
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            { "Searches","for","an","element", "that","matches","the","conditions"};

            string result = list.Find(MatchWord);
            Console.WriteLine($"發現字串 {result}");
        }

        private static bool MatchWord(string obj)
        {
            if (obj == "element") return true;
            else return false;
        }
    }
}
