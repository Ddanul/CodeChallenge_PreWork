using System;

namespace CodeChallenge_PreWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 4, 4, 4, 5 };
            Console.WriteLine(CheckScore(array, 4));

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
    }
}
