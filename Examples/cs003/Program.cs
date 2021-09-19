using System;
using System.Collections;

namespace cs003
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyIntIterator = new MyIntIterator();
            #region 使用 foreach 
            foreach (var item in MyIntIterator)
                Console.WriteLine(item);
            foreach (var item in MyIntIterator)
                Console.WriteLine(item);
            #endregion

            #region 使用 MoveNext 來瀏覽所有紀錄(這裡無法使用)
            //MyIntIterator.Reset();
            //while (MyIntIterator.MoveNext())
            //    Console.WriteLine(MyIntIterator.Current);
            #endregion
        }
    }

    /// <summary>
    /// 實作出 迭代器
    /// </summary>
    public class MyIntIterator : IEnumerable
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
