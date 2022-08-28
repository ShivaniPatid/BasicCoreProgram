using System;

namespace CoreProgram
{
    internal class LargestNumber
    {
        public static void FindLargestNumber()
        {
            Console.WriteLine("Enter number1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter nimber2");
            int number2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number3");
            int number3=Convert.ToInt32(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine(number1+" is Largest number");
            }
            else if(number2 > number1 && number2 > number3)
            {
                Console.WriteLine(number2+" is largest number");
            }
            else 
            {
                Console.WriteLine(number3+" is largest number");
            }
        }
    }
}
