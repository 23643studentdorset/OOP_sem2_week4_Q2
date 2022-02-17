using System;

namespace OOP_sem2_week4_Q2
{
    class Program
    {
        //Create a console-based program whose Main() method prompts the user for an integer
        //value and, in turn, passes the value to a method that squares the number and to a method
        //that cubes the number.
        //The Cube() method should call the Square() method. The Main()
        //method displays the results returned from each of the other methods.

        private static int square(int number)
        {
            return (int)Math.Pow((double)number, 2.0);            
        }
        private static int cube(int number)
        {
            return square(number) * number;
        }



        static void Main(string[] args)
        {

            bool flag = false;
            int number = 0;
            do
            {
                Console.WriteLine("input an integer");
                flag = !int.TryParse(Console.ReadLine(), out number);
                if (flag)
                {
                    Console.WriteLine("The value is not an integer");
                }
            } while (flag);

            Console.WriteLine("The square of {0} is {1}", number, Program.square(number));
            Console.WriteLine("The cube of {0} is {1}", number, Program.cube(number));

        }
    }
}
