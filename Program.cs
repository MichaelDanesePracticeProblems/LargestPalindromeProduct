using System;

namespace LargestPalindromeProduct
{
    /*
    A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

    Find the largest palindrome made from the product of two 3-digit numbers.
    */
    //Michael Danese
    class Program
    {
        static void Main(string[] args)
        {
        /*
          Will find the largest palindrome that is the product of two 3-digit numbers. 
          My solution was straightforward however there may be more room for improvement as it is O (n^2)
        */
            string initial, reversed;
            int multOne = 0, multTwo = 0, largestNum = 0, min = 100, max = 1000, numericRep;
            char[] transitionArray;
            for (int i = min; i < max; i++)
            {
                for (int j = min; j < max; j++)
                {//Loops through every possible combination of multiples of 3-digit numbers, setting the largest palindrome as it goes.
                    numericRep = i * j;
                    initial = numericRep.ToString();
                    transitionArray = initial.ToCharArray();
                    Array.Reverse(transitionArray);
                    reversed = new string(transitionArray);
                    if (initial.Equals(reversed))
                    {
                        numericRep = Int32.Parse(initial);
                        if (numericRep > largestNum)
                        {
                            largestNum = numericRep;
                            multOne = i;
                            multTwo = j;
                        }

                    }
                } 
            }
            //This secton prints the largest palindrome and what combination made it
            Console.Write(multOne);
            Console.Write(" * ");
            Console.Write(multTwo);
            Console.Write(" = ");
            Console.WriteLine(largestNum);
        }
    }
}
