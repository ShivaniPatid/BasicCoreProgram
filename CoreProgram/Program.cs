using System;

namespace CoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number\n 1. Flip Coin\t");
            int num=Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    FlipCoin.PercentageHeadsTails();
                    break;
                default:
                    Console.WriteLine("Entered wrong number");
                    break;
            }
        }
    }
}