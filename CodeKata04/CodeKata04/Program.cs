using System;
using DataStructures;

namespace CodeKata04
{
    class Program
    {
        static void Main(string[] args)
        {
            weatherData wd = new weatherData();
            FotbollData fd = new FotbollData();
            wd.findSmallestChange().print();
            fd.findSmallestChange().print();

            Console.WriteLine();

            string filepath = @"C:\Users\christoffergr\Documents\GitHub\testingDesktop\CodeKatas\CodeKata04\CodeKata04\bin\Debug\weather.dat";
            DRY_Data dd = new DRY_Data(filepath, 0, 1, 2);

            filepath = @"C:\Users\christoffergr\Documents\GitHub\testingDesktop\CodeKatas\CodeKata04\CodeKata04\bin\Debug\football.dat";
            DRY_Data dd2 = new DRY_Data(filepath, 1, 6, 8);

            dd.findSmallestChange().print();
            dd2.findSmallestChange().print();

            Console.ReadLine();
        }
    }
}
