using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // int sum = Sum();
            // Console.WriteLine(Sum());

            Sum();
            int first= 7;
            int second = 10;

            Console.WriteLine(Multiply(first, second));
            
            Multiply(first, second);

            Multiply(4, 5);

            DisplayNumbers(100);
        }

        static void Sum()
        {
            int a = 2;
            int b = 3;

            int sum = a + b;
            
            Console.WriteLine(sum);

        }

        static int Multiply(int a, int b)
        {
            return a * b;


        }

        static void DisplayNumbers(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
