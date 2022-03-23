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


            if (num2 == "")
            {

                maybe.Method(num2 = 3);


            }

            else
            {
                num2 converted = Convert.ToInt32;
                maybe.Method(num1 = 3, num2 = 4);
                maybe.Method(num1 = 3, converted = 4);
            }

        }
    }
}