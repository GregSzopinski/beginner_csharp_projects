using System;
using Algorithms;

namespace RunMergeSort
{
    static class Program
    {
        static void Main(string[] args)
        {
            TestMergeSort();
            Console.ReadKey();
        }

        private static void TestMergeSort()
        {
            int[] arrayToSort = {2, 3, 8, 8, 2, 3, 1, 7, 8, 9, 0, 1, 11, 656, 32, 42};
            arrayToSort = MergeSorter.MergeSort(arrayToSort);
            foreach(var number in arrayToSort)
            {
                Console.Write(number + " ");
            }
        }
    }
}