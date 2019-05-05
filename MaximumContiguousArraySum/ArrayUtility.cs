using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumContiguousArraySum
{
    class ArrayUtility
    {
        public static int[] GetArrayFromUserInput() {
            int[] array = null;
            Console.WriteLine("Enter the number or elements in the array");
            try
            {
                int numberElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements of the array separated by " +
                    "space, comma or semi-colon");
                String[] elements = Console.ReadLine().Split(' ',',',';');
                array = new int[numberElements];
                for (int index = 0; index < numberElements; index++) {
                    array[index] = int.Parse(elements[index]);
                }

            }catch(Exception exception){
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            return array;
        }

        public static void PrintMaximumContiguousArraySum(int[] array) {
            int max_ending_here = 0;
            int max_so_far = int.MinValue;

            for (int index = 0; index < array.Length; index++) {
                max_ending_here += array[index];

                if (max_ending_here < 0) {
                    max_ending_here = 0;
                }

                if (max_so_far < max_ending_here) {
                    max_so_far = max_ending_here;
                }
            }

            Console.WriteLine("Largest sum in contiguous array is "+max_so_far);
        }
    }
}
