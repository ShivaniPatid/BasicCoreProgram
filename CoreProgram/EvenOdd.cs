using System;


namespace CoreProgram
{
    internal class EvenOdd
    {
        public static void CheckEvenOdd()
        {
            int number;
            Console.WriteLine("Enter any number");
            number=Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine(number+" is a even");
            }
            else
            {
                Console.WriteLine(number+" is a odd");
            }
        }
    }
}
