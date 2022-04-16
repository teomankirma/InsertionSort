using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = random.Next(0, 20);
            }

            InsertionSort.Sort(numbers);

            Console.Write("Insertion Sort");
            Console.WriteLine(" ");
            Console.WriteLine(string.Join(" | ", numbers));
        }
    }
}
