using System;


namespace CoreProgram
{
    internal class Swapping
    {
        public static void SwapTwoNumbers()
        {
            int number1, number2, temp;
            Console.WriteLine("Enter the number1");
            number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENter the number2");
            number2= Convert.ToInt32(Console.ReadLine());

            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("Afetr Swapping");
            Console.WriteLine("number1 : "+number1+"\nnumber2 : "+number2);
        }
    }
}
