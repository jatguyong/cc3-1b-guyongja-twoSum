namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integers separated by commas: ");
            string numInput = Console.ReadLine();
            int[] numArray = Array.ConvertAll(numInput.Split(','), int.Parse);

            Console.Write("Enter the target sum: ");
            int target = int.Parse(Console.ReadLine());

            int[] result = TwoSum(numArray, target);
            Console.WriteLine("Output: [" + string.Join(", ", result) + "]");
        }

        static int[] TwoSum(int[] numArray, int target)
        {
            Dictionary<int, int> numDict = new Dictionary<int, int>();

            for (int i = 0; i < numArray.Length; i++)
            {
                int number = numArray[i];
                int targetNumber = target - number;

                // if the targetNumber exists in the dictionary
                if (numDict.ContainsKey(targetNumber))
                {
                    // return an integer array containing the index of the targetNumber and the current 'number'
                    return new int[] { numDict[targetNumber], i };
                }

                // only store the index of the first occurence of the number with duplicates
                if (!numDict.ContainsKey(number))
                    numDict[number] = i;
            }

            // else return an empty array
            return new int[0];
        }
    }
}
