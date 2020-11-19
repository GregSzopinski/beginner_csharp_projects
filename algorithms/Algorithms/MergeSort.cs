using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Algorithms
{
    public static class MergeSorter
    {
        public static int[] MergeSort(int[] numbers)
        {
            if (numbers.Length <= 1) return numbers; // base case
            var left = new List<int>();
            var right = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 > 0)
                {
                    left.Add(numbers[i]);
                }
                else
                {
                    right.Add(numbers[i]);
                }
            }

            left = MergeSort(left.ToArray()).ToList();
            right = MergeSort(right.ToArray()).ToList();

            return Merge(left, right); // todo: define merge
        }

        private static int[] Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();
            
            while (NotEmpty(left) && NotEmpty(right))
            {
                if (left.First() <= right.First())
                    MoveToResult(left, result);
                else
                    MoveToResult(right, result);
            }

            while (NotEmpty(left)) 
                MoveToResult(left, result);
            
            while (NotEmpty(right))
                MoveToResult(right, result);

            return result.ToArray();
        }

        // helper methods to keep to code cleaner
        private static bool NotEmpty(List<int> array)
        {
            return array.Count > 0;
        }

        private static void MoveToResult(List<int> array, List<int> result)
        {
            result.Add(array.First());
            array.RemoveAt(0);
        }
    }
}