using System;
using System.Collections.Generic;

namespace Week7Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palinedrome Detector");
            string myString = Console.ReadLine();
            string first = myString.Substring(0, myString.Length / 2);
            char[] arr   = myString.ToCharArray();

            Array.Reverse(arr);

            string temp   = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            if (first.Equals(second)) {
                Console.WriteLine("It is a palindrome");
            }
            else {
                Console.WriteLine("It is not a palindrome");
            }
            Console.WriteLine("Fibonacci Sequence:");
            List<int> fibonacci = new List<int>();
            fibonacci.Add(1);
            fibonacci.Add(1);
            
            int limit = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i<limit; i++) {
                fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);

            }
            for (int e = 0; e < fibonacci.Count; e++) {
                Console.Write(fibonacci[e] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Floyd's Triangle:");
            int row = Convert.ToInt16(Console.ReadLine());
            int natural = 1;
            int currentRow = 1;
            Console.WriteLine("   ");
            for (int a = 0; a < row; a++) {
                for (int b = 0; b < currentRow; b++) {
                    Console.Write(natural + " ");
                    natural++;
                }
                Console.WriteLine("");
                currentRow++;
            }
            /*int prime = Convert.ToInt32(Console.ReadLine());
            for (int c = 0; c < prime - 1; c++){
                if (prime % c == 0) {
                    Console.WriteLine("not a prime");
                    break;
                }
                

                
            }*/
            Console.WriteLine("Prime Number verifier:");
            int n = Convert.ToInt32(Console.ReadLine());   
            int prime = 0;
            for (int i = 1; i <= n; i++) {
                if (n % i == 0) {
                prime++;
                }
            }

            if (prime == 2) {
                Console.WriteLine("{0} is a Prime Number", n);
            } else {
                Console.WriteLine("Not a Prime Number");
            }
            Console.WriteLine("Star Triangle:");
            Console.WriteLine("");
            int row2 = Convert.ToInt16(Console.ReadLine());
            
            int currentRow2 = 1;
            for (int d = 0; d < row2; d++) {
                for (int f = 0; f < currentRow2; f++) {
                    Console.Write("*");
                    
                }
                Console.WriteLine("");
                currentRow2++;
            }
             int  digitNum,sum=0,digits;         
            Console.Write("Enter a number: ");      
            digitNum= int.Parse(Console.ReadLine());     
            while(digitNum>0)      
            {      
                digits=digitNum%10;      
                sum=sum+digits;      
                digitNum=digitNum/10;      
            }      
            Console.Write("Sum is= "+sum);
            int elevens = Convert.ToInt16(Console.ReadLine());
        }
    }}

