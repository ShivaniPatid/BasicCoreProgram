using System;


namespace CoreProgram
{
    internal class PrimeFactor
    {
        public static void PrimeFactors()
        {
            int isPrime;
            Console.WriteLine("Enter number for prime factor");
            int n=Convert.ToInt32(Console.ReadLine());
           
                for (int i = 2; i <= n; i++)
                {

                    if (n % i == 0)
                    {
                        isPrime = 1;
                        for (int j = 2; j <= i / 2; j++)
                        {
                            if (i % j == 0)
                            {
                                isPrime = 0;
                                break;
                            }

                        }
                        if (isPrime == 1)
                        {
                            Console.WriteLine(i + " is prime factor");
                        }
                    }
                }
                
                
            
        }
    }
}
