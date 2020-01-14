using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class TemperatureConversion
    {
        public static void Temperature()
        {
            Console.WriteLine("enetr celsius");
            Double x = Utility.UtiliReadDouble();
            Console.WriteLine("enetr fahrenheit");
            Double y = Utility.UtiliReadDouble();
            Double Fahrenheit = x * (9 / 5) + 32;
            Double Celsius= (y - 32) * 5 / 9;
            Console.WriteLine("celsius is: {0} and Fahrenheit is :{1}",Celsius,Fahrenheit);



        }
    }

}
