﻿using System;

namespace CoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number\n 1. Flip Coin\t 2. Leap Year\t 3. Print Table\t 4. Harmonic Number\t 5. Prime Factor");
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
                    Power.PrintTable();
                    break;
                case 4:
                    HarmonicNumber.HarmonicValue();
                    break;
                case 5:
                    PrimeFactor.PrimeFactors();
                    break;
                default:
                    Console.WriteLine("Entered wrong number");
                    break;
            }
        }
    }
}