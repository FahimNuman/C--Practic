using System;

namespace c_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.WriteLine("input first number:");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input Second number:");
            number2 = Convert.ToInt32(Console.ReadLine());

            temp = number1;
            number1 = number2;
            number2 = temp;


            Console.WriteLine("\First number" + number1);
            Console.WriteLine("\Second number" + number2);

        }
    }
}
