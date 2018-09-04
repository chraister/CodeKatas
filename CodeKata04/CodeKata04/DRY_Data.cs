using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeKata04
{
    class DRY_Data
    {
        public DRY_Data(string filepath, int firstIndex, int maxValueIndex, int minValueIndex)
        {
            text = System.IO.File.ReadAllLines(filepath);
            Splitter(firstIndex, maxValueIndex, minValueIndex);
        }

        private void Splitter(int firstIndex, int maxValueIndex, int minValueIndex)
        {
            for (int i = 0; i < text.Length - 1; i++)
            {
                string item = text[i].Trim();
                reg = new Regex("[a-zA-Z]");

                if (item != "" && !reg.IsMatch(item[0].ToString()))
                {
                    List<string> sList = new List<string>();
                    sList = item.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                    reg = new Regex("(-)(-)");
                    if (!reg.IsMatch(item))
                    {
                        nodes.Add(new Data(sList[firstIndex], int.Parse(sList[maxValueIndex].Trim('*')), int.Parse(sList[minValueIndex].Trim('*'))));
                    }
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

        Regex reg;
        List<Data> nodes = new List<Data>();
        string[] text;
    }
}
