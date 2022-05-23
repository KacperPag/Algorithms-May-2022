using System;
using System.Diagnostics;

namespace BubbleAndInsertionSort_May2022
{
    class Program
    {
        static Stopwatch stopwatch;
        static int[] numbers;
        static bool hasSwapped;

        static void Main(string[] args)
        {
            GenerateNumbers();
        }
        static void GenerateNumbers()
        {
            Console.WriteLine("How many numbers would you like to use?");
            int userInput = int.Parse(Console.ReadLine());
            numbers = new int[userInput];
            hasSwapped = true;
            Console.WriteLine("Generating numbers... Please wait");
            for (int i = 0; i < numbers.Length; i++)
            {
                Random random = new Random();
                numbers[i] = random.Next(0, 1000);
            }
            Console.WriteLine("Numbers have been generated!");
            Console.WriteLine("Which type of sort would you like to use? Bubble/Insertion Sort");
            if (Console.ReadLine().ToLower() == "bubble")
            {
                Console.WriteLine("You would like to sort it in ascending order or descending order?");
                if (Console.ReadLine().ToLower() == "ascending")
                {
                    BubbleSortAscendingOrder();
                }
                else
                {
                    BubbleSortDescendingOrder();
                }
            }
            else
            {
                Console.WriteLine("You would like to sort it in ascending order or descending order?");
                if (Console.ReadLine().ToLower() == "ascending")
                {
                    InsertionSortAscendingOrder();
                }
                else
                {
                    InsertionSortDescendingOrder();
                }
            }
        }
        static void ListNumbers()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        static void AskSortAgain()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Would you like to sort some numbers again?");
            if (Console.ReadLine().ToLower() == "yes")
            {
                GenerateNumbers();
            }
        }

        #region BubbleSort
        static void BubbleSortAscendingOrder()
        {
            Console.WriteLine("Bubble sort it is!");
            Console.WriteLine("These are the numbers that are going to be sorted...");
            ListNumbers();
            Console.WriteLine("Sorting... please wait...");
            stopwatch = new Stopwatch();
            stopwatch.Start();

            while (hasSwapped == true)
            {
                hasSwapped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    int currentNum = numbers[i];
                    int nextNum = numbers[i + 1];

                    if (currentNum > nextNum)
                    {
                        numbers[i] = nextNum;
                        numbers[i + 1] = currentNum;
                        hasSwapped = true;
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine("------------------------------");
            ListNumbers();
            Console.WriteLine("This sort took {0} ms", stopwatch.ElapsedMilliseconds);

            AskSortAgain();
        }
        static void BubbleSortDescendingOrder()
        {
            Console.WriteLine("Bubble sort it is!");
            Console.WriteLine("These are the numbers that are going to be sorted...");
            ListNumbers();
            Console.WriteLine("Sorting... please wait...");
            stopwatch = new Stopwatch();
            stopwatch.Start();

            while (hasSwapped == true)
            {
                hasSwapped = false;
                for (int i = 1; i < numbers.Length; i++)
                {
                    int currentNum = numbers[i];
                    int lastNum = numbers[i - 1];

                    if (currentNum > lastNum)
                    {
                        numbers[i] = lastNum;
                        numbers[i - 1] = currentNum;
                        hasSwapped = true;
                        ListNumbers();
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine("------------------------------");
            ListNumbers();
            Console.WriteLine("This sort took {0} ms", stopwatch.ElapsedMilliseconds);

            AskSortAgain();
        }
        #endregion BubbleSort

        #region InsertionSort
        static void InsertionSortAscendingOrder()
        {
            Console.WriteLine("Insertion sort it is!");
            Console.WriteLine("These are the numbers that are going to be sorted...");
            ListNumbers();
            Console.WriteLine("Sorting... please wait...");
            stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < numbers.Length - 1;)
            {
                int currentNum = numbers[i];
                int nextNum = numbers[i + 1];

                if (currentNum > nextNum)
                {
                    numbers[i] = nextNum;
                    numbers[i + 1] = currentNum;
                    if (i >= 1){ i = i - 1; }

                }
                else
                {
                    i++;
                }
            }
            stopwatch.Stop();
            Console.WriteLine("------------------------------");
            ListNumbers();
            Console.WriteLine("This sort took {0} ms", stopwatch.ElapsedMilliseconds);

            AskSortAgain();
        }
        static void InsertionSortDescendingOrder()
        {
            Console.WriteLine("Insertion sort it is!");
            Console.WriteLine("These are the numbers that are going to be sorted...");
            ListNumbers();
            Console.WriteLine("Sorting... please wait...");
            stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1; i < numbers.Length;)
            {
                int currentNum = numbers[i];
                int lastNum = numbers[i - 1];

                if (currentNum > lastNum)
                {
                    numbers[i] = lastNum;
                    numbers[i - 1] = currentNum;
                    if (i >= 1) { i = i - 1; }
                }
                else
                {
                    i++;
                }
            }
            stopwatch.Stop();
            Console.WriteLine("------------------------------");
            ListNumbers();
            Console.WriteLine("This sort took {0} ms", stopwatch.ElapsedMilliseconds);

            AskSortAgain();
        }
        #endregion InsertionSort
    }
}
