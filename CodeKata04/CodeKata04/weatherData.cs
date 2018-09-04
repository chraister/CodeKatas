using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using DataStructures;



namespace CodeKata04
{
    class weatherData
    {


        public weatherData()
        {
            text = System.IO.File.ReadAllLines(@"C:\Users\christoffergr\Documents\GitHub\testingDesktop\CodeKatas\CodeKata04\CodeKata04\bin\Debug\weather.dat");
            Splitter();
        }

        private void Splitter()
        {
            //då vi vet att det börjar på 2 rader n
            for (int i = 2; i < text.Length - 1; i++)
            {
                string item = text[i].Trim();
                List<string> sList = new List<string>();
                sList = item.Split(' ', text.Length, StringSplitOptions.RemoveEmptyEntries).ToList();

                nodes.Add(new Data(sList[0], int.Parse(sList[1].Trim('*')), int.Parse(sList[2].Trim('*'))));
            }
        }

        public Data findSmallestChange()
        {
            Data temp = nodes[0];

            foreach (var item in nodes)
            {
                if (item < temp)
                {
                    temp = item;
                }
            }
            return temp;
        }

        List<Data> nodes = new List<Data>();
        string[] text;
    }
}
