﻿//<auto-generated/>
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class TwoDArray
    {
        public static void Two()
        {
            Console.WriteLine("Creating Two D array");
            Console.WriteLine("enter the rows");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("enter no of column");
            int column = int.Parse(Console.ReadLine());
            int[,] array = new int[rows,column];

            Console.WriteLine("print your elements");
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(array[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}