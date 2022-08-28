using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProgram
{
    internal class QuotientRemainder
    {
        public static void ComputeQuotientRemainder()
        {
            int quotient, remainder;
            Console.WriteLine("Enter the dividend");
            int dividend=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divisior");
            int divisior=Convert.ToInt32(Console.ReadLine());
            if (dividend >= divisior)
            {
                quotient = dividend / divisior;
                remainder = dividend % divisior;
               
                Console.WriteLine("Quotient is " + quotient);
                Console.WriteLine("Reminder is " + remainder);
            }
            else
            {
                Console.WriteLine("Devidend must be greater then a divisior");
            }
        }
    }
}
