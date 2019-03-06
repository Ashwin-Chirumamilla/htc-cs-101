using System;
using System.Collections.Generic;

namespace Week5Challenges
{
    class Program
    {
        public static int AddOne(int x) {
            x += 1;
            return x;
        }
        public static int AddThree(int y ) {
            y += 3;
            return y;
        }
        public static int MultThree(int z) {
            z *= 3;
            return z;
        }
        public static bool LeapYear(int year) {
            List<int> leapYears = new List<int>();
            bool leapYeartf;
            if (year % 4 == 0 && year % 100 != 0) {
                leapYeartf =  true;
            }
            else if (year % 400 == 0) {
                leapYeartf =  true;
            }
            else {
                leapYeartf = false;
            }
            for (int i = 0; i < 50; i++) {
                year += 4;
                if (year % 4 == 0 && year % 100 != 0) {
                leapYears.Add(year);
                }
                else if (year % 400 == 0) {
                leapYears.Add(year);
                }
                
            }
            for (int e=0; e < leapYears.Count; e++) {
                Console.WriteLine(leapYears[e]);
            }
            return leapYeartf;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(LeapYear(1980));
        }
        
    }
}
