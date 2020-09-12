using System;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            string p1, p2, p3;
            Console.WriteLine("Enter correct number");
            p1 = Console.ReadLine();
            if (p1 == "12345")
            {
                Console.WriteLine("you pass Level 1");
                Console.WriteLine("go another level");
                p2 = Console.ReadLine();
                if (p2== "00000")
                {
                    Console.WriteLine("you pass Level 2");
                    Console.WriteLine("go another level");
                    p3 = Console.ReadLine();
                    if (p3 == "11111")
                    {
                        Console.WriteLine("you complete full  mission");
                    }
                    else
                    {
                        Console.WriteLine("your password was incorret 3");
                    }

                }
                else
                {
                    Console.WriteLine("your password was incorret 2");
                }

            }
            else
            {
                Console.WriteLine("your password was incorret 1");
            }
            Console.Read();

        }
    }
}
