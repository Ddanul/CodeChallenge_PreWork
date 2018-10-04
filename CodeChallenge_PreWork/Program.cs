using System;

namespace CodeChallenge_PreWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 1, 4, 4, 4, 5 };
            //Console.WriteLine(CheckScore(array, 4));

            //Console.WriteLine(IsLeapYear(1900));

            //int[] sequence = { 0, -7, 0 };
            //Console.WriteLine(IsPerfect(sequence));

            int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            Console.WriteLine(SumArray(myArray));
        }

        static int CheckScore(int[] numArray, int number)
        {
            int count = 0;
            for(int i=0; i<numArray.Length; i++)
            {
                if(numArray[i] == number)
                {
                    count++;
                }
            }
            return number*count;
        }

        static string IsLeapYear(int year)
        {
            if(year%4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return "This is a Leap Year!";
                    }
                    else
                    {
                        return "This is NOT a Leap Year!";
                    }
                }
                return "This is a Leap Year!";
            }
            return "This is NOT a Leap Year";
        }

        static string IsPerfect(int[] sequence)
        {
            int product = 1;
            int sum = 0;
            foreach(int number in sequence)
            {
                if (number < 0)
                {
                    return "No";
                }
                product *= number;
                sum += number;
            }
            if (product == sum)
            {
                return "Yes";
            }
            return "No";
        }

        static int[] SumArray(int[,] multiDimArray)
        {
            int[] thisArray = { 1, 2, 3, 4 };
            return thisArray;
        }
    }
}
