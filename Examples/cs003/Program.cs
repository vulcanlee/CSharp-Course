using System;
using System.Collections;

namespace cs003
{
    // 反覆運算器 Iterator : 使用 yield 定義反覆運算器 範例程式碼
    class Program
    {
        static void Main(string[] args)
        {
            var myIntSequence = new MyIntSequence();
            #region 使用 foreach 來瀏覽所有紀錄
            foreach (var item in myIntSequence)
                Console.WriteLine(item);
            foreach (var item in myIntSequence)
                Console.WriteLine(item);
            #endregion

            #region 使用低階方法 MoveNext 來瀏覽所有紀錄
            IEnumerator enumerator = myIntSequence.GetEnumerator();
            while (enumerator.MoveNext())
                Console.WriteLine(enumerator.Current);
            #endregion
        }
    }

    /// <summary>
    /// 實作出 迭代器 Iterator
    /// </summary>
    public class MyIntSequence : IEnumerable
    {
        int[] data = { 1, 2, 3 };

        #region IEnumerable 介面實作方法
        public IEnumerator GetEnumerator()
        {
            foreach (var item in data)
            {
                yield return item;
            }
        }
        #endregion

    }
}
