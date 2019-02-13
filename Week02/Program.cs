using System;

namespace Week02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create variables and do things with them!
            bool truefalse = false;
            string letters = "Just some random text";
            double decimals = 3.14;
            int wholes = 9001;
           Console.WriteLine(truefalse.ToString());
           Console.WriteLine(letters);
           Console.WriteLine(decimals.ToString());
           Console.WriteLine(wholes.ToString());

            Console.WriteLine("Random Number Challenge");
            Random rnd = new Random();
            int random = rnd.Next(26);
            int random1 = rnd.Next(1, 7);
            int random2 = rnd.Next(1, 7);
            int sum = random1 + random2;
            Console.WriteLine(random.ToString());
            Console.WriteLine(random1.ToString());
            Console.WriteLine(random2.ToString());
            Console.WriteLine(sum.ToString());

            Console.WriteLine("Random Password:");
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var charsupper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var charslower = "abcdefghijklmnopqrstuvwxyz";
            var charsnum = "0123456789";
            var stringChars = new char[10];
            

              
            
        
            stringChars[0] = charsupper[rnd.Next(charsupper.Length)];
            stringChars[1] = charslower[rnd.Next(charslower.Length)];
            stringChars[2] = charsnum[rnd.Next(charsnum.Length)];
            for (int i = 3; i < stringChars.Length; i++)
                {
                stringChars[i] = chars[rnd.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            Console.WriteLine(finalString);
        }
    }
}
