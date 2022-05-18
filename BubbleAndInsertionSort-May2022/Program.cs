using System;

namespace BubbleAndInsertionSort_May2022
{
    class Program
    {
        static int[] numbers;
        static int numOfRuns;

        static void Main(string[] args)
        {
            //generate numbers function is run at the start of the program
            GenerateNumbers();
        }
        static void GenerateNumbers()
        {
            //this creates a new array of size 10
            numbers = new int[10];
            //numOfRuns is set to 0
            numOfRuns = 0;
            Console.WriteLine("Generating numbers... Please wait");
            //10 numbers are randomly generated
            for (int i = 0; i < numbers.Length; i++)
            {
                Random random = new Random();
                //the numbers that are randomly generated are between 0 and 100
                numbers[i] = random.Next(0, 100);
            }
            Console.WriteLine("Numbers have been generated!");
            //this asks the user for which type of soring algorithm they want to use
            Console.WriteLine("Which type of sort would you like to use? Bubble/Insertion Sort");
            //if the user input is buuble then the bubble sort algorithm sorts the numbers
            if (Console.ReadLine().ToLower() == "bubble")
            {
                BubbleSort();
            }
            //otherwise it sorts the numbers using insertion sort
            else
            {
                InsertionSort();
            }
        }

        //this lists the numbers in the array
        static void ListNumbers()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        static bool IsSorted()
        {
            return false;
        }

        #region BubbleSort
        static void BubbleSort()
        {
            Console.WriteLine("Bubble sort it is!");
            Console.WriteLine("These are the numbers that are going to be sorted...");
            ListNumbers();

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
                        ListNumbers();
                    }
                }
                numOfRuns++;
            }
            Console.WriteLine("----------------------------------------------");
            ListNumbers();
        }
        #endregion BubbleSort

        #region InsertionSort
        static void InsertionSort()
        {
            Console.WriteLine("Insertion sort it is!");
            Console.WriteLine("These are the numbers that are going to be sorted...");
            ListNumbers();

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
