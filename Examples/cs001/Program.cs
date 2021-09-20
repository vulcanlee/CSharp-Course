using System;
using System.Collections;

namespace cs001
{
    // 列舉器 IEnumerator 與 IEnumerable 介面實作方法 範例程式碼
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

    // 客製化序列/集合
    public class MyIntSequence : IEnumerable
    {
        int[] data = { 1, 2, 3 };

        #region IEnumerable 介面實作方法
        public IEnumerator GetEnumerator() => new MyIntIterator(data);
        #endregion
    }

    /// <summary>
    /// 實作出 列舉器 Enumerator
    /// </summary>
    public class MyIntIterator : IEnumerator
    {
        int[] data;
        int currentIndex = -1;

        public MyIntIterator(int[] dataSequence) { data = dataSequence; }

        #region IEnumerator 介面實作方法
        public object Current { get { return data[currentIndex]; } }
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
