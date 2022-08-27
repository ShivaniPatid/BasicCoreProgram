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
            Console.WriteLine("enter number of times you want to filp the coin : ");
            int n=Convert.ToInt32(Console.ReadLine());
            double heads, tails;
            for (int i = 0; i < n; i++)
            {
                Random random = new Random();
                int v=random.Next(0,2);
                Console.WriteLine("random value : "+v);
                if (v == 0)
                {
                    t_count++;
                }
                else
                {
                    h_count++;
                }

            }
            heads = h_count / (double)n * 100;
            tails = t_count / (double)n * 100;
            Console.WriteLine("Persentage of heads : "+heads+"%");
            Console.WriteLine("Percentage of tails : "+tails+"%");
        }
    }
}
