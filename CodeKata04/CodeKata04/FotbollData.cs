using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeKata04
{
    class FotbollData
    {

        public FotbollData()
        {
            text = System.IO.File.ReadAllLines(@"C:\Users\christoffergr\Documents\GitHub\testingDesktop\CodeKatas\CodeKata04\CodeKata04\bin\Debug\football.dat");
            Splitter();
        }

        private void Splitter()
        {
            //då vi vet att det börjar på 2 rader n
            for (int i = 2; i < text.Length - 1; i++)
            {
                string item = text[i].Trim();
                List<string> sList = new List<string>();
                sList = item.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!reg.IsMatch(item))
                {
                    nodes.Add(new Data(sList[1], int.Parse(sList[6]), int.Parse(sList[8])));
                }
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

        Regex reg = new Regex("(-)(-)");
        List<Data> nodes = new List<Data>();
        string[] text;
    }
}

