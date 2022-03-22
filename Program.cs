using System;

namespace Classes_and_Methods_Assignment_2
{
    class Program
    {
        public static void Main(string[] args)
        {

            theMaking maybe = new theMaking();

            int num1;

            int num2;

            Console.WriteLine("Please input a number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("This second number is optional");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 == null)
            {
                maybe.method();

            }

            else
            {
                int option2 = num1 * num2;
            }

        }
    }




    /////////////////////////////////this is the second class that also has the method 
    ///////////////////////
    ///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_2
    {
        class theMaking
        {

            public int Method(int num1, int num2 = 4)
            {
                int answer = num1 + num2;
                return answer;
            }
        }
    }


}

