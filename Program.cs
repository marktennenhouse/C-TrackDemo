using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 34, 543, 45, 4345, 5454, 34543, 2234, 2342, 10, 35, 3 };
            int min = GetMin(numbers);

            int max = GetMax(numbers);

            decimal average = GetAverage(numbers);
            Console.WriteLine(string.Format("Min is: {0}, Max is: {1}, Average is: {2}", min, max, average));

            DisplayMultiplicationTable(6);
            Console.ReadLine();
        }


        static void DisplayMultiplicationTable(int max)
        {
            for (int outerCounter = 1; outerCounter <= max; outerCounter++)
            {
                for (int counter = 1; counter <= max; counter++)
                {
                    Console.Write(counter * outerCounter + " " );
                }
                Console.WriteLine();
            }
        }


        static int GetMin(int[] someArray)
        {
            int lowest = someArray[0];
            foreach (int num in someArray)
            {
                if (num < lowest)
                {
                    lowest = num;
                }
                
            }
            return lowest;
        }
        static int GetMax(int[] someArray)
        {
            int highest = 0;
            foreach (int num in someArray)
            {
                if (num > highest)
                {
                    highest = num;
                }

            }
            return highest;

        }
        static decimal GetAverage(int[] someArray)
        {
            int total = 0;
            foreach (int num in someArray)
            {
                total += num;

            }
            return total / someArray.Length - 1;
        }
    }
}
