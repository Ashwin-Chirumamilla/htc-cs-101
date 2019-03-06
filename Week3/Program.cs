using System;

namespace Week02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd or even:");
            string evenoroddinput = Console.ReadLine();
            double evenorodd = Convert.ToDouble(evenoroddinput);

            if (evenorodd % 2 != 0) {
                Console.WriteLine("Odd");
            }
            else {
                Console.WriteLine("Even");
            }
            Console.WriteLine("Order Three Numbers:");
            double[] threenumbers = new double[3];
            threenumbers[0] = Convert.ToDouble(Console.ReadLine());
            threenumbers[1] = Convert.ToDouble(Console.ReadLine());
            threenumbers[2] = Convert.ToDouble(Console.ReadLine());
            Array.Sort(threenumbers);
            Console.WriteLine(threenumbers[2]);
            Console.WriteLine("Vowel or Consanant:");
            string vowel = Console.ReadLine();
            if (vowel == "a" || vowel == "e"  || vowel == "i" || vowel == "o" || vowel == "u") {
                Console.WriteLine("Vowel");
            }
            else {
                Console.WriteLine("Consanant");
            }

            Console.WriteLine("Name of Shape:");
            int sides = Convert.ToInt32(Console.ReadLine());
            if (sides == 3) {
                Console.WriteLine("Triangle");
            }
            else if (sides == 4) {
                Console.WriteLine("Square");
            }
            else if (sides == 5) {
                Console.WriteLine("Pentagon");
            }
            else if (sides == 6) {
                Console.WriteLine("Hexagon");
            }
            else if (sides == 7) {
                Console.WriteLine("Septagon");
            }
            else if (sides == 8) {
                Console.WriteLine("Octagon");
            }
            else if (sides == 9) {
                Console.WriteLine("Nanogon");
            }
            else if (sides == 10) {
                Console.WriteLine("Decagon");
            }
            else {
                Console.WriteLine("Side number error");
            }

            Console.WriteLine("Month days");
            string month = (Console.ReadLine()).ToLower();
            if (month == "january" || month == "march" || month == "may" || month == "july" || month == "august" || month == "october" || month == "december") {
                Console.WriteLine("31 days");
            }
            else if (month == "february") {
                Console.WriteLine("28 or 29 days");
            }
            else {
                Console.WriteLine("30 days");
            }
            Console.WriteLine("Triangle Type:");
            double[] triangle = new double[3];
            triangle[0] = Convert.ToDouble(Console.ReadLine());
            triangle[1] = Convert.ToDouble(Console.ReadLine());
            triangle[2] = Convert.ToDouble(Console.ReadLine());
            if (triangle[0] == triangle[1] && triangle[1] == triangle[2]) {
                Console.WriteLine("Equilateral");
            }
            else if (triangle [0] == triangle [1] || triangle[1] == triangle [2]) {
                Console.WriteLine("Isosceles");
            }
            else {
                Console.WriteLine("Scalene");
            }
            Console.WriteLine("Faces on Money");
            double money = Convert.ToDouble(Console.ReadLine());
            if (money == 1) {
                Console.WriteLine("George Washington");
            }
            else if (money == 2) {
                Console.WriteLine("Thomas Jefferson");
            }
            else if (money == 5) {
                Console.WriteLine("Abarham Lincoln");
            }
            else if (money == 10) {
                Console.WriteLine("Alexander Hamilton");
            }
            else if (money == 20) {
                Console.WriteLine("Andrew Jackson");
            }
            else if (money == 50) {
                Console.WriteLine("Ulysses S. Grant");
            }
            else if (money == 100) {
                Console.WriteLine("Benjamin Franklin");
            }
            else if (money == 500) {
                Console.WriteLine("William McKinley");
            }
            else if (money == 1000) {
                Console.WriteLine("Grover Cleveland");
            }
            else if (money == 5000) {
                Console.WriteLine("James Madison");
            }
            else if (money == 10000) {
                Console.WriteLine("Salmon P. Chase");
            }
            else if (money == 100000) {
                Console.WriteLine("Woodrow Wilson");
            }
            else {
                Console.WriteLine("Bill does not exist");
            }
            string seasonmonth = Console.ReadLine();
            int day = Convert.ToInt32(Console.ReadLine());

            if ((seasonmonth == "april")){
                Console.WriteLine("Spring");
            }
            else if (seasonmonth == "march" && day >= 20 ) {
                Console.WriteLine("Spring");
            }
            else if (seasonmonth == "june" && day < 21) {
                Console.WriteLine("Spring");
            }
            else if (seasonmonth == "june" && day >= 21) {
                Console.WriteLine("Summer");
            }
            else if(seasonmonth == "july" || seasonmonth == "august") {
                Console.WriteLine("Summer");
            }
            else if (seasonmonth == "september" && day < 22) {
                Console.WriteLine("Summer");
            }
            else if (seasonmonth == "september" && day >= 22) {
                Console.WriteLine("Fall");
            }
            else if(seasonmonth == "october" || seasonmonth == "november") {
                Console.WriteLine("Fall");
            }
            else if (seasonmonth == "december" && day < 21) {
                Console.WriteLine("Fall");
            }
            else if (seasonmonth == "december" && day >= 21) {
                Console.WriteLine("Wnter");
            }
            else if(seasonmonth == "january" || seasonmonth == "february") {
                Console.WriteLine("Winter");
            }
            else if (seasonmonth == "march" && day < 20) {
                Console.WriteLine("Winter");
            }
            int Num;
            string lisceneplate = Console.ReadLine();
            char[] liscence = lisceneplate.ToCharArray();
                if (int.TryParse(liscence[0].ToString (), out Num) && int.TryParse(liscence[1].ToString (), out Num)) {
                    Console.WriteLine("integer");
                }            
            

            
            }
        }
    }
