using System;

namespace cs006
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello World!";

            #region 使用 Foreach 陳述式來瀏覽
            foreach (var item in myString)
            {
                Console.Write(item);
            }
            #endregion
            Console.WriteLine();

            #region 使用列舉器來瀏覽
            CharEnumerator charEnumerator = myString.GetEnumerator();
            while(charEnumerator.MoveNext())
            {
                Console.Write(charEnumerator.Current);
            }
            #endregion
        }
    }
}
