using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata02
{
    class BinarySearch
    {
        public BinarySearch(int size)
        {
            numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = i;
            }
        }

        public int search(int searchValue)
        {
            int midIndex;
            int leftIndex = 0;
            int rightIndex = numbers.Length - 1;

            while (leftIndex <= rightIndex)
            {
                midIndex = leftIndex + ((rightIndex - leftIndex) / 2);

                if (numbers[midIndex] == searchValue)
                {
                    return midIndex;
                }
                else
                {
                    if (numbers[midIndex] > searchValue)
                    {
                        rightIndex = midIndex - 1;
                    }
                    else
                    {
                        leftIndex = midIndex + 1;
                    }
                }

            }

            return -1;
        }

        int[] numbers;
    }
}
