using System;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 10, 3, 5, 1, 7, 9, 11, 2};

            PrintArray("Unsorted", numbers);

            HeapSort(numbers, numbers.Length);

            PrintArray("Sorted", numbers);
        }

        public static void HeapSort(int[] numbers, int length)
        {
            // heapify up the heap to create max heap 
            for (int i = length / 2 - 1; i >= 0; i--)
                Heapify(numbers, length, i);

            // max heap has been built
            // take root and swap with the lowest element
            for (int i = length - 1; i >= 0; i--)
            {
                int temp = numbers[0];
                numbers[0] = numbers[i];
                numbers[i] = temp;

                // call Heapify on the reduced heap
                Heapify(numbers, i, 0);
            }

        }

        public static void Heapify(int[] numbers, int length, int i)
        {
            int largest = i;
            int leftChild = i * 2 + 1;
            int rightChild = i * 2 + 2;

            if (leftChild < length && numbers[largest] < numbers[leftChild])
                largest = leftChild;
            if (rightChild < length && numbers[largest] < numbers[rightChild])
                largest = rightChild;

            if(largest != i)
            {
                int temp = numbers[i];
                numbers[i] = numbers[largest];
                numbers[largest] = temp;

                Heapify(numbers, length, largest);
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
