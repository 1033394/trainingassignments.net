using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_codebase_test1
{
    class q1
    {
        static void Main()
        {
            Console.WriteLine("enter a string:");
            string input = Console.ReadLine();
            Console.WriteLine("enter position to remove (0-based):");
            int position = int.Parse(Console.ReadLine());
            if (position>=0 && position < input.Length)
            {
                string result = RemovecharAtposition(input, position);
                Console.WriteLine("Result:" + result);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid position.position should be in the range 0 to string lengthy -1.");
                Console.ReadLine();
            }
        }
        static string RemovecharAtposition(string str, int index)
        {
            if (index < 0 || index >= str.Length)
             {
                return str;
            }
            return str.Remove(index, 1);
        }
    }

}
