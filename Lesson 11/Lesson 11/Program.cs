// See https://aka.ms/new-console-template for more information

using System;

namespace Program
{
    class MyClass
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n<=0)
            {
                Console.WriteLine("error");
                return;
            }

            int i = 1;
            while (n>=1)
            {
                i *= n;
                n -= 2;
            }
            Console.WriteLine($"Двойной фактериял равно {i}");
        }
    }
}

