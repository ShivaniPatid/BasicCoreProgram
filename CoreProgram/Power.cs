using System;
namespace CoreProgram
{
    internal class Power
    {
        public static void PowerOfN()
        {
            
            Console.WriteLine("Please enter range for finding power table");
            int range=Convert.ToInt32(Console.ReadLine());

            
            if (range < 0 || range > 32)
            {
                Console.WriteLine("Please enter number between 0 to 31");
            }
            else
            {
                for (int i = 0; i < range; i++)
                {
                    Console.WriteLine((int)Math.Pow(i, 2));
                }

            }
        }
    }
}
