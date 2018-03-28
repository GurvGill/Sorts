using System;

/* Bubblesort algorithm sorting lowest to highest.
 * starting from the left of the array to the right 
 * left number is compared with the number to the right
 * if the left number is larger swap the numbers
 * do this all the way through the array then repeat
 * n times resulting in sorting the array right to left.
 * 
 * Worst case: O(n^2)
 * Best case: O(n) */
namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting randomly generated numbers!");
            int length = 10;

            int[]  numbers = initializeArray(length);

            PrintArray("Unsorted array", numbers);

            BubbleSort(numbers);

            PrintArray("Sorted array", numbers);

            Console.WriteLine("Done!");
        }

        public static int[] initializeArray(int length)
        {
            int[] numbers = new int[length];
            Random random = new Random();

            for (int i = length - 1; i > 0; i--)
            {
                numbers[i] = random.Next(1, 100);
            }

            return numbers;
        }

        public static void BubbleSort(int[] numbers)
        {
            Boolean swap;
            for (int i = 0; i < numbers.Length; i++)
            {
                swap = false;
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        swap = true;
                    }
                }
                if (!swap)
                    break;
            }
        }

        public static void PrintArray(string title, int[] numbers)
        {
            string result = title + ": ";
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i] + ", ";
            }
            Console.WriteLine(result.Substring(0, result.Length - 2));
        }
    }
}
