using System;
using System.Reflection.Metadata.Ecma335;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sozu daxil edin");
            string word = Console.ReadLine();
            Console.WriteLine(Task5(word)); 


        }
        static bool Task5(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 48 && str[i] <= 57)
                {

                    return true;

                }
            } return false;



        }    
 
        
        

        
       

    }      
} 