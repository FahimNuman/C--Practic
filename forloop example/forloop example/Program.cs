using System;

namespace forloop_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=15;i++)
            {
                Console.WriteLine("{0}*{1}={2}",num,i,num*i);
            }
            Console.WriteLine();

        }
    }
}
