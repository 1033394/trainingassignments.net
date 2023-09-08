using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assognment3
{
    class q1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a word: ");
            string inputword = Console.ReadLine();
            int length = inputword.Length;
            Console.WriteLine($"the length of the word \"{inputword}\" is : {length}");
            Console.ReadLine();

        }
       
    }
}
