
using System;
using System.Threading;

namespace CharNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CharNumbers("Salam", 'a'));
        }
        static int CharNumbers(string str,char cr)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] ==cr)
                {
                    count++;
                    
                }

            }  return count;
                
        
        }


    }
}    
       



