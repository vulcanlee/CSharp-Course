using System;
using System.Collections;
using System.Collections.Generic;

namespace cs002
{
    // 迭代器 Iterator IEnumerator<int>與IEnumerable<int> 介面實作方法
    class Program
    {
        static void Main(string[] args)
        {
            var MyIntIterator = new MyIntIterator();
            #region 使用 foreach 
            foreach (var item in MyIntIterator)
                Console.WriteLine(item);
            #endregion

            #region 使用 MoveNext 來瀏覽所有紀錄
            MyIntIterator.Reset();
            while (MyIntIterator.MoveNext())
                Console.WriteLine(MyIntIterator.Current);
            #endregion
        }
    }

    /// <summary>
    /// 實作出 迭代器
    /// </summary>
    public class MyIntIterator : IEnumerator<int>, IEnumerable<int>
    {
        int[] data = { 1, 2, 3 };
        int currentIndex = -1;

        #region IEnumerable 介面實作方法
        public IEnumerator<int> GetEnumerator() { return this; }

        IEnumerator IEnumerable.GetEnumerator() { return this; }
        #endregion

        #region IEnumerator 介面實作方法
        public int Current { get { return data[currentIndex]; } }

        object IEnumerator.Current => data[currentIndex];

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (currentIndex >= data.Length - 1)
                return false;
            return ++currentIndex < data.Length;
        }

        public void Reset() { currentIndex = -1; }
        #endregion
    }
}
