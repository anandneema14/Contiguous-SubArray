using System;
using System.Linq;

namespace Contiguous_SubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Program Constraints
            /*test Cases
            1. It should be greater than 1
            2. It should be less than 1000
            */
            /*Size of Array
            1. It should be greater than 1
            2. It should be less than 1000
             */
            /*Elements in Array
            1. It should be greater than -5000
            2. It should be less than 5000
             */
            #endregion

            #region User Input Instructions
            Console.WriteLine("============================================================");
            Console.WriteLine("Please Read the instructions befor providing your inputs, otherwise Program will EXIT:");
            Console.WriteLine("1. Test Cases value should be Integer and should lie between 1 and 1000");
            Console.WriteLine("2. Array Size should be Integer and should lie between 1 and 1000");
            Console.WriteLine("3. Elements in Array should be Integer and should lie between -5000 and 5000");
            Console.WriteLine("============================================================");
            #endregion

            #region Test Cases
            //Get Test Cases value
            Console.WriteLine("Enter Test Cases Value: ");
            string testCases = Console.ReadLine();

            // Check if value is integer
            int value;
            if (!int.TryParse(testCases, out value))
            {
                Console.WriteLine("Please enter a valid integer value!");
                return;
            }
            int testCaseValue = Convert.ToInt32(testCases);

            //Console.WriteLine("You entered {0}", testCaseValue);

            //Check if value is within the range
            if (testCaseValue > 1000 || testCaseValue < 1)
            {
                Console.WriteLine("Enter test cases between 1 and 1000");
                Console.Read();
                return;
            }
            #endregion

            //Get Array size and corresponding Array elements for each test case and get the Maximum contiguous sum
            for (int x = 0; x < testCaseValue; x++)
            {
                #region Array Size
                Console.WriteLine("============================================================");
                Console.WriteLine("Enter Array Size for Test case " + Convert.ToInt32(x + 1) + ": ");
                string arraySize = Console.ReadLine();

                //Check if value is valid intege value
                if (!int.TryParse(arraySize, out value))
                {
                    Console.WriteLine("Please enter a valid integer value!");
                    Console.Read();
                    return;
                }
                int arraySizeValue = Convert.ToInt32(arraySize);

                //Console.WriteLine("You entered {0}", arraySizeValue);

                //Check if value is within the range
                if (arraySizeValue > 1000 || arraySizeValue < 1)
                {
                    Console.WriteLine("Enter array size between 1 and 1000");
                    Console.Read();
                    return;
                }
                #endregion

                #region Array Elements
                int[] elements = new int[arraySizeValue];
                Console.WriteLine("Enter Array Elements: ");

                for (int i = 0; i < elements.Length; i++)
                {
                    string arrayElement = Console.ReadLine();

                    //Check if value is valid integer value
                    if (!int.TryParse(arrayElement, out value))
                    {
                        Console.WriteLine("Please enter a valid integer value!");
                        Console.Read();
                        return;
                    }
                    elements[i] = Convert.ToInt32(arrayElement);
                }
                if (elements.Max() > 5000 || elements.Min() < -5000)
                {
                    Console.WriteLine("Please enter array elements in valid range as defined in the instructions above!");
                    Console.Read();
                    return;
                }
                #endregion

                Console.WriteLine("Maximum contiguous sum is " +
                                        maxSubArraySum(elements));
            }
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
