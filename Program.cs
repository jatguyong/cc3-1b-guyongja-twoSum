using System;
using System.Collections.Generic;

namespace TwoSum {
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] numArray = {2, 5, 7, 11, 4};
            int target = 9;
            int[] result = TwoSum(numArray, target);
            Console.WriteLine("Output: [" + string.Join(", ", result) + "]");
        }

        public static int[] TwoSum (int[] numArray, int target)
        {
            Dictionary<int, int> numDict = new Dictionary<int, int>();

            for (int i = 0; i < numArray.Length; i++)
            {
            int number = numArray[i];
            int targetNumber = target - number;
            
            // if the targetNumber exists in the dictionary
            if (numDict.ContainsKey(targetNumber)) {
                // return an integer array containing the index of the targetNumber and the current 'number'
                return new int[] { numDict[targetNumber], i };
            }

            // only store the index of the first occurence of the number with duplicates
            if (!numDict.ContainsKey(number))
                numDict[number] = i;
            }

            // else return empty array
            return new int[0];
        }
    }
}
