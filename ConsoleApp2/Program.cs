using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReverceA();
            FrequentB();
        }

        static void ReverceA()
        {
            int[] arr = { 1, 2, 3, 4, 5 }; // Corrected array initialization
            int[] arr2 = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[arr.Length - 1 - i]; // Corrected index calculation for reversing
            }
            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }
        }

        static void FrequentB()
        {
            int[] nums = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
            int result = FindMostFrequentNumber(nums);
            Console.WriteLine($"The most frequent number is: {result}");
        }

        static int FindMostFrequentNumber(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                throw new ArgumentException("Input array cannot be null or empty.");
            }

            int mostFrequentNumber = nums[0];
            int maxCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int currentCount = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == nums[i])
                    {
                        currentCount++;
                    }
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    mostFrequentNumber = nums[i];
                }
            }

            return mostFrequentNumber;
        }
    }
}
