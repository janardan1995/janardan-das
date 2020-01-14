using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class NewtonSqrt
    {
        public static void Newton()
        {
            Console.WriteLine("enter the no to perform newton method");
            Double c = Utility.UtiliReadDouble();
            Double t = c;
            Double epsilon =1e-15;
            while(Math.Abs(t - c / t) > epsilon * t)
            {
                t=((c/t)+t)/ 2.0;
            }
            Console.WriteLine(t);
        }
    }
}
