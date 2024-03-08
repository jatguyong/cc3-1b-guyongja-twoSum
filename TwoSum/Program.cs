namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integers separated by commas: ");
            string numInput = Console.ReadLine();
            int[] numArray = Array.ConvertAll(numInput.Split(','), int.Parse);

            Console.Write("Enter target: ");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine("Output: [" + string.Join(", ", TwoSum(numArray, target)) + "]");
        }

        static int[] TwoSum(int[] numArray, int target)
        {
            int[] result = new int[2];

            for (int i = 0; i < numArray.Length; i++)
            {
                for (int j = i+1; j < numArray.Length; j++)
                {
                    if (numArray[i] + numArray[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;

                        return result;
                    }
                }
            }

            return result;
        }
    }
}
