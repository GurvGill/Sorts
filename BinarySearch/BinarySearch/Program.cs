using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10;
            int number = 12;

            int[] sortedArray = InitializeArray(length);

            PrintArray("Sorted list", sortedArray);

            int start = 0, end = sortedArray.Length - 1;

            int index = BinarySearch(sortedArray, start, end, number);
            if(index == -1)
            {
                Console.WriteLine("Number is not in array.");
            }
            else
            {
                Console.WriteLine("Index: " + index + " Number: " + sortedArray[index]);
            }

        }

        public static int BinarySearch(int[] sortedArray, int start, int end, int number)
        {

            if (start > end)
            {
                return -1;
            }
            else
            {
                int middle = (start + end) / 2;

                // number index is found
                if (number == sortedArray[middle])
                    return middle;

                // number is on the right side of array
                if (number > sortedArray[middle])
                    return BinarySearch(sortedArray, middle+1, end, number);
               
                // else number must be on the left side of array
                return BinarySearch(sortedArray, start, middle-1, number);
            }
        }

        public static int[] InitializeArray(int length)
        {
            int[] numbers = new int[length];

            for (int i = length - 1; i >= 0; i--)
            {
                numbers[i] = i+10;
            }

            return numbers;
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
