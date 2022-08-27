using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProgram
{
    internal class HarmonicNumber
    {
        public static void HarmonicValue()
        {
            double num = 0;
            Console.WriteLine("Enter the harmonic you want to find: ");
            int n=Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.Write("1 / {0} + ",i);
                num += (1 / (float) i);
                
            }
            Console.WriteLine();
            Console.WriteLine("Harmonic value {0} is : {1}",n,num);
        }
    }
}
