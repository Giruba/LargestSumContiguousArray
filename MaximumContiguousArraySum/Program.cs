using System;

namespace MaximumContiguousArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Contiguous Array Sum!");
            Console.WriteLine("-----------------------------");
            int[] array = ArrayUtility.GetArrayFromUserInput();
            ArrayUtility.PrintMaximumContiguousArraySum(array);
            Console.ReadLine();
        }
    }
}
