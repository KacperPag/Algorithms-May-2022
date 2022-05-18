using System;

namespace BubbleAndInsertionSort_May2022
{
    class Program
    {
        static int[] numbers;
        static int numOfRuns;

        static void Main(string[] args)
        {
            GenerateNumbers();
        }
        static void GenerateNumbers()
        {
            numbers = new int[10];
            numOfRuns = 0;
            Console.WriteLine("Generating numbers... Please wait");
            for (int i = 0; i < numbers.Length; i++)
            {
                Random random = new Random();
                numbers[i] = random.Next(0, 100);
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

        static void ListGeneratedNumbers()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        
        #region BubbleSort
        static void BubbleSort()
        {
            Console.WriteLine("Bubble sort it is!");
            Console.WriteLine("These are the numbers that are going to be sorted...");
            ListGeneratedNumbers();

            while (numOfRuns <= 10)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    int currentNum = numbers[i];
                    int nextNum = numbers[i + 1];

                    if (currentNum > nextNum)
                    {
                        numbers[i] = nextNum;
                        numbers[i + 1] = currentNum;
                    }
                }
                numOfRuns++;
            }
            Console.WriteLine("----------------------------------------------");
            ListGeneratedNumbers();
        }
        #endregion BubbleSort

        #region InsertionSort
        static void InsertionSort()
        {
            Console.WriteLine("Insertion sort it is!");
            Console.WriteLine("These are the numbers that are going to be sorted...");
            ListGeneratedNumbers();

/*            while (inOrder == false)
            {
                for (int i = 0; i < generatedNumbers.Length; i++)
                {

                }
            }*/
        }
        #endregion InsertionSort
    }
}
