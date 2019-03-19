using System;

namespace Week6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            Console.WriteLine("What number would you like to cap the program at?:");
            double cap = Convert.ToDouble(Console.ReadLine());
            while (x <= cap) {
            if (x % 2 == 0) {
                Console.WriteLine(x);
            }
            x++;
            }
        }
    }
}
