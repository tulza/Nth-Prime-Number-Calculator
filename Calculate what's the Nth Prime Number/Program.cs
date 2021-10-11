
using System;
using System.Collections.Generic;

namespace Calculate_what_s_the_Nth_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // the Nth prime number you would like to find
            int NthPrimeNumber = 1000;
            //

            int PrimeAt = 1;
            bool isPrime = false;
            ulong Number = 0;
            int count = 1;

            for (Number = 3; ; Number += 2)
            {
                double MaxNumber = Math.Round(0.5 * Number);

                for (ulong i = 3; ; i += 2)
                {
                    if (i > MaxNumber)
                    {
                        isPrime = true;
                        break;
                    }

                    if (Number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }

                if (isPrime == true)
                {
                    PrimeAt += 1;
                    Console.WriteLine($"{PrimeAt}) {Number}");
                }

                if (PrimeAt == NthPrimeNumber)
                {
                    Console.WriteLine($"\nThe {NthPrimeNumber}th prime is {Number}");
                    break;
                }
            }
        }
    }
}
