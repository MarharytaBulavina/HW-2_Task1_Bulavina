using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                Console.WriteLine("Please, enter the word, or input 'stop' to exit");
                string palindrome = Console.ReadLine();
                if (palindrome == "stop")
                {
                    break;
                }
                    
                char[] array = palindrome.ToCharArray();
             
                Array.Reverse(array);
                   
                string p_reverse = new string(array);
                  
                if (palindrome.Equals(p_reverse))
                    {
                        Console.WriteLine("Yay! Your word is a palindrome!");
                    }
                  
                else
                    {
                        Console.WriteLine("Nay. Your word is NOT a palindrome!");
                    }
                
            }
            
        }
    }
}
