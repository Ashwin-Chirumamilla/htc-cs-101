using System;
using System.Collections.Generic;
using System.Linq;
namespace Week6Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            Console.WriteLine("Random Number Guesser:");
            double randNum = rnd.Next(1, 20);
            double guess  = 0;
            double year = 2019;
            double xValue;
            List<double> leapYears = new List<double>();
            while (guess != randNum) {
                guess = Convert.ToDouble(Console.ReadLine());
                if (guess > randNum) {
                    Console.WriteLine("Too high");
                }
                else if (guess < randNum) {
                    Console.WriteLine("Too low");
                }
            }
            Console.WriteLine("You are correct!");
            while (!(year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) {
                year++;
            }
            for(int i=0; i<50;i++) {
                year+=4;
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) {
                    leapYears.Add(year);
                }
            }
            for (int e=0; e<leapYears.Count; e++) {
                Console.WriteLine(leapYears[e]);
            }
            Console.WriteLine("Put in xValue");
            xValue = Convert.ToDouble(Console.ReadLine());
            while (xValue > 0) {
                xValue-=0.5;
                Console.WriteLine(xValue);
            }
            Console.WriteLine("Squares:");
            for(int z=0; z <= 25; z++) {
                Console.WriteLine(Math.Pow(z, 2));
            }
            Console.WriteLine("Addition Factorial:");
            int xyz = Convert.ToInt32(Console.ReadLine());
            int[] sums = new int[xyz + 1];
            for (int n = xyz - 1; n >= 0; n--) {
                sums[n] = n;
            }
            Console.WriteLine(sums.Sum());

            Console.WriteLine("Largest Factor:");
            double factor = Convert.ToDouble(Console.ReadLine());
            double largeFactor = factor - 1;
            double a = 0.1;
            while (!(a % 1 == 0)) {
                largeFactor--;
                a = factor / largeFactor;
            }
            Console.WriteLine(largeFactor);
            Console.WriteLine("Star ASCII");
            int height = Convert.ToInt32(Console.ReadLine());
            int currentHeight = 0;
            int increment = 0;
            while (currentHeight <= height) {
                if (currentHeight == 0) {
                    for(int c = 0; c < height; c++) {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                else {
                    for (int d = 0; d < height - currentHeight; d++) {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    for (int b = 0; b < currentHeight + increment; b++) {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                Console.WriteLine("");
                if (currentHeight >= 1) {
                    increment++;
                }
                currentHeight++;
            }
            currentHeight--;
            increment--;
             while (currentHeight >= 0) {
                if (currentHeight == 0) {
                    for(int c = 0; c < height; c++) {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                else {
                    for (int d = 0; d < height - currentHeight; d++) {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    for (int b = 0; b < currentHeight + increment; b++) {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                Console.WriteLine("");
                if (currentHeight <= height) {
                    increment--;
                }
                currentHeight--;
            }
        }
    }
}
