using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata02
{
    class BinarySearchRecursive
    {
        public BinarySearchRecursive(int size)
        {
            numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = i;
            }
        }

        public int search(int searchValue)
        {
            return search(searchValue,0, numbers.Length-1);
        }

        private int search(int searchValue, int leftIndex, int RightIndex)
        {
            int midIndex;

            while (leftIndex <= RightIndex)
            {
                midIndex = leftIndex + ((RightIndex - leftIndex) / 2);

                if (midIndex == searchValue)
                {
                    Console.WriteLine("recursive search found the value at index:" + midIndex);
                    return midIndex;
                }
                else
                {
                    if (numbers[midIndex] > searchValue)
                    {
                        return search(searchValue, leftIndex, midIndex - 1);
                    }
                    else
                    {
                        return search(searchValue, midIndex + 1, RightIndex);
                    }
                }
            }
            return -1;
        }


        int[] numbers;
    }
}
