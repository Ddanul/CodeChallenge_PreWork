using System;

namespace CodeChallenge_PreWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 1, 4, 4, 4, 5 };
            //Console.WriteLine(CheckScore(array, 4));

            Console.WriteLine(IsLeapYear(1996));

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
                if (year % 100 != 0)
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

            return "This is not a Leap Year";
        }
    }
}
