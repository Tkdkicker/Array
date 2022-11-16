using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayTasks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AccessIndividualElements();
            Console.WriteLine("\n");
            ForLoop();
            Console.WriteLine("\n");
            ForeachLoop();
            Console.WriteLine("\n");
            Mean();//Add up all numbers then divide by amount
            Console.WriteLine("\n");
            Median();//Middle number
            Console.WriteLine("\n");
            Mode();//Most common number
            Console.WriteLine("\n");
            Range();//Highest and lowest number divided by total amount
        }

        private static void AccessIndividualElements()
        {
            Console.WriteLine("Accessing individual elements");

            int[] grades = new int[5] { 54, 65, 72, 30, 45 };

            Console.WriteLine(grades[0]);

            Console.ReadKey();
        }

        private static void ForLoop()
        {
            Console.WriteLine("Using a 'for' loop to print all array elements");

            int[] grades = new int[5] { 54, 65, 72, 30, 45 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(grades[i]);
            }

            Console.ReadKey();
        }

        private static void ForeachLoop()
        {
            Console.WriteLine("Using a 'foreach' to print all array elements");

            int[] grades = new int[5] { 54, 65, 72, 30, 45 };

            foreach (int i in grades)
            {
                Console.WriteLine("Element = " + i);
            }

            Console.ReadKey();
        }

        private static void Mean()//Add up all numbers then divide by amount
        {
            Console.WriteLine("Looking for the mean value\n");
            Console.WriteLine("Enter the first number to go in the array");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number to go in the array");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number to go in the array");
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth number to go in the array");
            int number4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fifth number to go in the array");
            int number5 = int.Parse(Console.ReadLine());

            int[] numbers1To5 = new int[5];
            numbers1To5[0] = number1;
            numbers1To5[1] = number2;
            numbers1To5[2] = number3;
            numbers1To5[3] = number4;
            numbers1To5[4] = number5;

            int firstStep = number1 + number2 + number3 + number4 + number5;
            int mean = firstStep / 5;

            Console.WriteLine("The 'mean' answer is: " + mean);
        }

        private static void Median()//Middle number
        {
            Console.WriteLine("Looking for the median value\n");
            Console.WriteLine("Enter the first number to go in the array");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number to go in the array");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number to go in the array");
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth number to go in the array");
            int number4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fifth number to go in the array");
            int number5 = int.Parse(Console.ReadLine());

            int[] numbers1To5 = new int[5];
            numbers1To5[0] = number1;
            numbers1To5[1] = number2;
            numbers1To5[2] = number3;
            numbers1To5[3] = number4;
            numbers1To5[4] = number5;

            int median = number3;

            Console.WriteLine("The 'median' answer is: " + median);
        }

        private static void Mode()//Most common number
        {
            Console.WriteLine("Looking for the most common value\n");
            Console.WriteLine("Enter the first number to go in the array");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number to go in the array");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number to go in the array");
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth number to go in the array");
            int number4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fifth number to go in the array");
            int number5 = int.Parse(Console.ReadLine());

            int[] numbers1To5 = new int[5];
            numbers1To5[0] = number1;
            numbers1To5[1] = number2;
            numbers1To5[2] = number3;
            numbers1To5[3] = number4;
            numbers1To5[4] = number5;

            Array.Sort(numbers1To5);

            var dict = new Dictionary<int, int>();
            foreach (var sort in numbers1To5)
            {
                if (dict.ContainsKey(sort))
                {
                    dict[sort]++;
                }
                else
                {
                    dict[sort] = 1;
                }
            }

            foreach (var pair in dict)
            {
                if (pair.Value > 1)
                {
                    Console.WriteLine("The 'most' answer is: " + pair.Key + " with " + pair.Value + " occurences");
                }
            }
        }

        private static void Range()//Highest and lowest number divided by total amount
        {
            Console.WriteLine("Looking for the range value\n");
            Console.WriteLine("Enter the first number to go in the array");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number to go in the array");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number to go in the array");
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth number to go in the array");
            int number4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fifth number to go in the array");
            int number5 = int.Parse(Console.ReadLine());

            int[] numbers1To5 = new int[5];
            numbers1To5[0] = number1;
            numbers1To5[1] = number2;
            numbers1To5[2] = number3;
            numbers1To5[3] = number4;
            numbers1To5[4] = number5;

            int max = numbers1To5.Max();
            int min = numbers1To5.Min();
            int firstStep = max + min;
            int total = firstStep / 5;

            Console.WriteLine("The 'range' answer is: " + total);
        }
    }
}