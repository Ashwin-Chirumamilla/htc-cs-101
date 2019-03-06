using System;

namespace Week5
{
    class Program
    {
        static double Addition(double addfirstinteger, double addsecondinteger) {
            return addfirstinteger + addsecondinteger;
        }

        static double Subtraction(double subFirstInt, double subSecInt) {
            return subFirstInt - subSecInt;
        }
        static double Multiplication(double multFirstInt, double multSecInt) {
            return multFirstInt * multSecInt;
        }
        static double Division(double divFirstInt, double divSecInt) {
            return divFirstInt/divSecInt;
        }
        static void Quadratic(double a, double b, double c, out double negative, out double positive) {
            double discriminant = Math.Pow(b, 2) + (-4 * a * c);
            positive = ((-1 * b) + Math.Sqrt(discriminant))/ (2*a);
            negative = ((-1 * b) - Math.Sqrt(discriminant))/ (2*a);
            
        }
        static void Main(string[] args)
        {
            string ops = null;
            double positivereturn;
            double negativereturn;
            double thirdint = 0;
            Console.WriteLine("First number:");
            double firstint = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second number:");
            double secint = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Would you like to use quadratic formula?");
            string quad = Console.ReadLine();
            if (quad == "yes") {
                Console.WriteLine("Enter third number for quadratic formula (Enter  to skip):");
                thirdint = Convert.ToDouble(Console.ReadLine());
            }
            else {
                Console.WriteLine("Enter symbol for operation (+, -, *, /):");
                ops = Console.ReadLine();
            }
            if (ops == "+") {
                string add = Convert.ToString(Addition(firstint, secint));
                Console.WriteLine("sum: " + add);
            }
            else if (ops == "-") {
                string sub = Convert.ToString(Subtraction(firstint, secint));
                Console.WriteLine("difference: " + sub);
            }
            else if(ops == "*") {
                string mult = Convert.ToString(Multiplication(firstint, secint));
                Console.WriteLine("product: " + mult);
            }
            else if (ops == "/") {
                string div = Convert.ToString(Division(firstint, secint));
                Console.WriteLine("quotient: " + div);
            }
            else if(quad == "yes") {
                Quadratic(firstint, secint, thirdint, out positivereturn, out negativereturn);
                string first = Convert.ToString(positivereturn);
                string second = Convert.ToString(negativereturn);
                Console.WriteLine("First solution: " + first);
                Console.WriteLine("Second solution: " + second);
            }
            }
            
        }
    }

