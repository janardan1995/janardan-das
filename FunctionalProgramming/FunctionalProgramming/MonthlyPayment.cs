using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class MonthlyPayment
    {
        public static void Payment()
        {
            Console.WriteLine("enetr principal");
            Double p = Utility.UtiliReadDouble();
            Console.WriteLine("enetr year");
            Double y = Utility.UtiliReadDouble();
            Console.WriteLine("enetr rate");
            Double R = Utility.UtiliReadDouble();
            Double n = 12 * y;
            Double r = R/(12*100);
            Double Payment = (p * r) / (1-Math.Pow(1+r,(-n)));
            Console.WriteLine("Monthly payment is: {0}",Payment);
            
        }
    }
}
