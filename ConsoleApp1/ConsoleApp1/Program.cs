using System;
using System.Linq;

namespace Contiguous_SubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCaseValue = 2;
            
            int[] elements1 = new int[5];
            int[] elements2 = new int[8];

            for (int x = 0; x < testCaseValue; x++)
            {
                if (x == 0)
                {
                    elements1 = new int[5] { 1, 2, 3, 4, 5 };
                }
                else if (x == 1)
                {
                    elements2 = new int[8] { -2, -3, 4, -1, -2, 1, 5, -3 };
                }
            }
            Console.WriteLine(maxSubArraySum(elements1));
            Console.WriteLine(maxSubArraySum(elements2));
            Console.Read();
        }

        /// <summary>
        /// Max contiguous Sum Logic
        /// 1. Check for all positive contiguous segment of array
        /// 2. Keep track of maximum sum
        /// 3. Each time we get a positive sum compare it with max sum calculated above
        /// 4. if it is greater update maximum sum with new value
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        private static int maxSubArraySum(int[] inputArray)
        {
            int arraySize = inputArray.Length;
            int maxValue = int.MinValue;
            int maxEndValue = 0;

            for (int i = 0; i < arraySize; i++)
            {
                maxEndValue = maxEndValue + inputArray[i];

                if (maxValue < maxEndValue)
                {
                    maxValue = maxEndValue;
                }
                if (maxEndValue < 0)
                {
                    maxEndValue = 0;
                }
            }
            return maxValue;
        }
    }
}
