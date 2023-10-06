using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    class q3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a word: ");
            string userinput = Console.ReadLine();
            if(ispalindrome(userinput))
            {
                Console.WriteLine("the word is a palindrome.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("the word is not a palindrome.");
                Console.ReadLine();
            }
        }
        static bool ispalindrome(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string reverseword = new string(charArray);
            return word.Equals(reverseword, StringComparison.OrdinalIgnoreCase);
        }
    }
}
