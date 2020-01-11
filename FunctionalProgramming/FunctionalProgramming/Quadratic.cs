﻿//<auto-generated/>
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class Quadratic
    {
        public static void Quad()
        {
            Console.WriteLine("enter three no a,b and c");
            Console.WriteLine("enter the value of a");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of b");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of c");
            double c = int.Parse(Console.ReadLine());
            double determinant = b * b - 4 * a * c;
            double root1, root2;
            if (determinant > 0)
            {
                root1 = (-b + Math.Sqrt(determinant)) / (2 * a);
                root2 = (-b - Math.Sqrt(determinant)) / (2 * a);
                Console.WriteLine("Roots are real and unique");
                Console.WriteLine("root1 = {0:00} and root2 = {1:00}", root1, root2);
            }
            // Condition for real and equal roots
            else if (determinant == 0)
            {
                root1 = root2 = -b / (2 * a);
                Console.WriteLine("Roots are real and same");
                Console.WriteLine("root1 = root2 = {0:00}", root1);
            }
            // If roots are not real
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-determinant) / (2 * a);
                Console.WriteLine("Roots are imaginary");
                Console.WriteLine("root1 = {0:00}+{1:00}i and root2 ={2:00}-{3:00}i", realPart, imaginaryPart, realPart, imaginaryPart);
            }
        }
      
    }
    
}