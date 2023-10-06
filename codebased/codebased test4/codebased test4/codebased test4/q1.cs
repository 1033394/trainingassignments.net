using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebased_test4
{
    class q1

    {

        static void Main()

        {

            string filePath = "q1.txt"; 



           

            using (StreamWriter writer = new StreamWriter(filePath, true))

            {

                Console.WriteLine("Give some text to append to the file (Ctrl+Z to finish):");



                while (true)

                {

                    string inp = Console.ReadLine();

                    if (inp == null)

                        break;



                    writer.WriteLine(inp);

                }



                Console.WriteLine("given Text appended successfully.");

            }

        }

    }
}