using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class q2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string: ");
            string inputstring = Console.ReadLine();
            Console.WriteLine("enter a letter to count: ");
            char lettertocount= Console.ReadLine()[0];
            int count = countletteroccurances(inputstring, lettertocount);
            Console.WriteLine($"the letter '{lettertocount}' appears{count} times in the string.");
            Console.ReadLine();

        }
        static int countletteroccurances(string inputstring, char lettertocount)
        {
            int count = 0;
            foreach (char c in inputstring)
            {
                if(char.ToLower(c)== char.ToLower(lettertocount))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
