using System;
using System.Diagnostics;

namespace CodeKata02
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            TimeSpan ts = new TimeSpan();

            watch.Start();
            BinarySearch bs = new BinarySearch(1000000000);
            bs.search(10605);
            watch.Stop();
            ts = watch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
           ts.Hours, ts.Minutes, ts.Seconds,
           ts.Milliseconds / 10);
            Console.WriteLine("RunTime for iterative:" + elapsedTime);

            watch.Reset();
            Console.WriteLine("reseting time----------------------------------------Time has been reset");

            watch.Start();
            BinarySearchRecursive bsR = new BinarySearchRecursive(1000000000);
            bsR.search(10605);
            watch.Stop();
            ts = watch.Elapsed;

            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
           ts.Hours, ts.Minutes, ts.Seconds,
           ts.Milliseconds / 10);
            Console.WriteLine("RunTime for recursive:" + elapsedTime);

            Console.ReadLine();
        }
    }
}
