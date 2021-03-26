using System;
using System.Collections.Generic;

namespace week5_lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the word here: " );
            string chWord = Console.ReadLine().ToLower();
            Stack<char> wordStack = new Stack<char>(chWord);
            int i = 0;
          
                for (i = 0; i < Convert.ToInt32(chWord.Length/2); i++)
                {
                    if (chWord[i] == wordStack.Pop())
                    {
                    continue;
                    }
                    else
                    {
                    break;
                }
                    
                }
            if (i== Convert.ToInt32(chWord.Length/2))
            {
                Console.WriteLine(chWord + " " + "is palindrome");
            }
            else
            {
                Console.WriteLine(chWord + " " + "is not palindrome");
            }
            
            

        }
    }
}
