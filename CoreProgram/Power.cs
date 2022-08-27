using System;
namespace CoreProgram
{
    internal class Power
    {
        public static void PrintTable()
        {
            const int POWER_OF = 2;
            Console.WriteLine("Enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
          
            for(int i = 1; i <= num; i++)
            {
                int result = POWER_OF * i;
                Console.Write("{0} * {1} = ",POWER_OF,i);
                Console.WriteLine(result);
            }
        }
    }
}
