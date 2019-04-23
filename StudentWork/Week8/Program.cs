using System;

namespace Week8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many hats would you like:");
            double repeat = Convert.ToDouble(Console.ReadLine());
            for (int i =0;i<repeat; i++) {
                printHat();
            }
            double centimeters = InToCm();
            Console.WriteLine(centimeters);
            string nameOutput = HiName();
            Console.WriteLine(nameOutput);
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            PasswordCheck(password);
            Console.WriteLine("Enter code");
            string code = Console.ReadLine();
            Console.WriteLine("Enter price:");
            double price = Convert.ToDouble(Console.ReadLine());
            
            double finalPrice = CouponCode(price, code);
            Console.WriteLine("Final Price" + finalPrice);

        
        }
        public static void printHat() {
            Console.WriteLine("   .--------.");
            Console.WriteLine("  /          `.");
            Console.WriteLine(" |         .-. .");
            Console.WriteLine(" |         |  `.|");
            Console.WriteLine(" |_________|   <|>");
            Console.WriteLine("(___________)");
        }
        public static double InToCm() {
            Console.WriteLine("Inches:");
            double inches = Convert.ToDouble(Console.ReadLine());
            double centimeters = inches * 2.54;
            return centimeters;
        }
        public static string HiName() {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            name = "Hi, " + name;
            return name;
            
        }

        public static void PasswordCheck(string password) {
            if (password == "incorrect") {
                Console.WriteLine("Correct Password");
            }
            else {
                Console.WriteLine("Incorrect Password");
            }
        }
        public static double CouponCode(double price, string code) {
            switch(code) {
                case "PUNCH":
                    price = price * 0.85;
                    break;
                case "HANDBOOK":
                    price = price * 0.75;
                    break;
                case "FREE":
                    price = 0;
                    break;
                default:
                    price = price;
                    break;
            }
            return price;
        }
    } }

