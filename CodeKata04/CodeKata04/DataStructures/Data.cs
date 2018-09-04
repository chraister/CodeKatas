using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Data
    {
        public Data(string entry1, int maxValue, int minValue)
        {
            this.entry1 = entry1;

            if (maxValue > minValue)
            {
                this.maxValue = maxValue;
                this.minValue = minValue;
            }
            else
            {
                this.maxValue = minValue;
                this.minValue = maxValue;
            }

        }

        public void print()
        {
            Console.WriteLine("name: " + entry1 + ", difference: " + (maxValue - minValue));
        }

        //används för att hitta noden med minst skillnad

        public static bool operator <(Data lhs, Data rhs)
        {
            bool status = false;

            if (lhs.maxValue - lhs.minValue < rhs.maxValue - rhs.minValue)
            {
                status = true;
            }
            return status;
        }

        public static bool operator >(Data lhs, Data rhs)
        {
            return !(lhs < rhs);
        }

        public static bool operator <=(Data lhs, Data rhs)
        {
            bool status = false;

            if (lhs.maxValue - lhs.minValue <= rhs.maxValue - rhs.minValue)
            {
                status = true;
            }
            return status;
        }

        public static bool operator >=(Data lhs, Data rhs)
        {
            return !(lhs <= rhs);
        }

        private string entry1;
        private int maxValue; //largest entry
        private int minValue; //smallest entry
    }
}
