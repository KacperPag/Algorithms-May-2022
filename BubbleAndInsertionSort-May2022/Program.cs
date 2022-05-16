using System;

namespace BubbleAndInsertionSort_May2022
{
    class Program
    {
        static int[] generatedNumbers;
        static int[] sortedNumbers;
        static bool inOrder;

        static void Main(string[] args)
        {
            GenerateNumbers();
        }
        static void GenerateNumbers()
        {
            generatedNumbers = new int[10];
            sortedNumbers = new int[10];
            inOrder = false;
            Console.WriteLine("Generating numbers... Please wait");
            for (int i = 0; i < generatedNumbers.Length; i++)
            {
                Random random = new Random();
                generatedNumbers[i] = random.Next(0, 100);
            }
            Console.WriteLine("Numbers have been generated!");
            Console.WriteLine("Which type of sort would you like to use? Bubble/Insertion Sort");
            if (Console.ReadLine().ToLower() == "bubble")
            {
                BubbleSort();
            }
            else
            {
                InsertionSort();
            }
        }
        static void BubbleSort()
        {
            Console.WriteLine("Bubble sort it is!");
            Console.WriteLine("These are the numbers that are going to be sorted...");
            for (int i = 0; i < generatedNumbers.Length; i++)
            {
                Console.WriteLine(generatedNumbers[i]);
            }

            while (inOrder == false)
            {
                for (int i = 0; i < generatedNumbers.Length; i++)
                {

                }
            }
        }
        static void InsertionSort()
        {
            Console.WriteLine("Insertion sort it is!");
            Console.WriteLine("These are the numbers that are going to be sorted...");
            for (int i = 0; i < generatedNumbers.Length; i++)
            {
                Console.WriteLine(generatedNumbers[i]);
            }
        }
    }
}
