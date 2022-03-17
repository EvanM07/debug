using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            ////this is a infinite loop
            //for (int a = 0; a < 50; a--)
            //{
            //    Console.WriteLine("value : {0}", a);
            //}
            //Console.ReadLine();

            ////fixed the loop
            //for (int a = 0; a < 50; a++)
            //{
            //    Console.WriteLine("value : {0}", a);
            //}
            //Console.ReadLine();


            //for (int i = 0; i <10000; i++ )
            //{
            //    Console.WriteLine(i);
            //}

            //for (int x = 0; x <= 500; x++)
            //{
            //    Console.WriteLine(x);
            //}


            List<string> things = new List<string>() { "car", "dog", "cat", "house", "vaccuum", "table", "cup" };

            Console.WriteLine(string.Join(", ", things));
            Console.ReadLine();

            Console.WriteLine("Please choose a word in the list");
            string input = Console.ReadLine();

            foreach (string thing in things)
            {
                if (input == things)
                {
                    Console.WriteLine(input);
                }

                else
                {
                    Console.WriteLine("sorry do not understand");
                }
            }
        }
    }
}
