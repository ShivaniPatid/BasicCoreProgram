using System;

namespace CoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number\n 1. Flip Coin\t 2. Leap Year\t 3. Print Table\t 4. Harmonic Number\t 5. Prime Factor\n 6. Compute Quotient and Remainder\t 7. Swap two numbers\t 8. Check even or odd\t 9. check vowel or consonant");
            int num=Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    FlipCoin.PercentageHeadsTails();
                    break;
                case 2:
                    LeapYear.CheckLeapYear();
                    break;
                case 3:
                    Power.PowerOfN();
                    break;
                case 4:
                    HarmonicNumber.HarmonicValue();
                    break;
                case 5:
                    PrimeFactor.PrimeFactors();
                    break;
                case 6:
                    QuotientRemainder.ComputeQuotientRemainder();
                    break;
                case 7:
                    Swapping.SwapTwoNumbers();
                    break;
                case 8:
                    EvenOdd.CheckEvenOdd();
                    break;
                case 9:
                    VowelConsonant.CheckVowelConsonant();
                    break;
                default:
                    Console.WriteLine("Entered wrong number");
                    break;
            }
        }
    }
}