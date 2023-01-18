using System;
using System.Security.Cryptography;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 5, 8, 11 };
            Console.WriteLine(Task3(numbers, 20));
            
        }


        static int Task3(int[] arr,int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==num)
                {
                    return i;
                }

            }
            return-1;
        }














    }
}
