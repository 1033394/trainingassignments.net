using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class q2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a word: ");
            string input = Console.ReadLine();
            string reversed = ReverseWord(input);
            Console.WriteLine("reversed word: "+ reversed);
            Console.ReadLine();

        }
        static string ReverseWord(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
