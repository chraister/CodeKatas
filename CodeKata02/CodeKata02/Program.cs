using System;

namespace CodeKata02
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinarySearch bs = new BinarySearch(20);
            //bs.search(15);

            BinarySearchRecursive bsR = new BinarySearchRecursive(20);
            bsR.search(15,0,19);

        }
    }
}
