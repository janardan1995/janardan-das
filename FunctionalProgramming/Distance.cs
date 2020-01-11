using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class Distance
    {
        public static void Dist()
        {
            Console.WriteLine("Euclidean distance from the point (x, y) to the origin (0, 0)");
            Console.WriteLine("enter x-axis");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter y-axis");
            int y = int.Parse(Console.ReadLine());
            double distance =Math.Sqrt(x * x + y * y);
            Console.WriteLine("Euclidean distance from the point ({0}, {1}) to the origin (0, 0) is : {2}",x,y,distance);
        }
        
    }
}
