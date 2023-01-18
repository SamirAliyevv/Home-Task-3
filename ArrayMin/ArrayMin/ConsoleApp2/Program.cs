



using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 2, 5, 45, 6, 7, 4, 23, 1 };
            Console.WriteLine(MinNumber(numbers));



        }

        static int MinNumber(int[]arr)
        {
            //Verilmiş ədədlər siyahısındaki ədədlərdən ən kiçiyini tapan metod
            int minimum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]<minimum)
                {
                  minimum= arr[i];
                }
                
            } 
            return minimum;
        }
        
        
        
        







    }

 







    
    
    
}
