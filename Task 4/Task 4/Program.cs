using System;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa sozu daxil edin ");
            string word=Console.ReadLine();
            var result=ReversTheWord(word);
            Console.WriteLine(result);  
        }


        static string ReversTheWord(string word)
        {
            string oppoStr = "";
            for (int i = word.Length-1;i>=0; i--)
            {
                oppoStr+= word[i];  
            }
            return oppoStr;
        }
        
        
























    }

}
