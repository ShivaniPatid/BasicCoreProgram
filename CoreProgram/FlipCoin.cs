using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProgram
{
    internal class FlipCoin
    {
        public static void PercentageHeadsTails()
        {
            int h_count = 0, t_count = 0;
            double heads, tails;
            Console.WriteLine("enter number of times you want to filp the coin : ");
            int number=Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                for (int i = 0; i < number; i++)
                {
                    Random random = new Random();
                    double randomnum = random.NextDouble();
                    
                    if (randomnum > 0.5)
                    {
                        Console.WriteLine("head");
                        h_count++;
                    }
                    else
                    {
                        Console.WriteLine("tail");
                        t_count++;
                    }

                }
                heads = h_count * 100 / number;
                tails = t_count *100 / number;
                Console.WriteLine("Persentage of heads : " + heads + "%");
                Console.WriteLine("Percentage of tails : " + tails + "%");
            }
            else
            {
                Console.WriteLine("Give only positive number");
            }
        }
    }
}
