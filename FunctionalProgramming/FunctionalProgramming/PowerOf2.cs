﻿
//<auto-generated/>
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class PowerOf2
    {
        public static void Power()
        {
            Console.WriteLine("Enter the no up which you wanna print table of 2");
            int no = int.Parse(Console.ReadLine());
            double[] array = new double[no + 1];
            for (int i = 1; i <= no; i++)
            {
                if (i == 0)
                {
                    array[i] = 1;
                }
                else
                {


                    double a = Math.Pow(2, i);
                    array[i] = a;

                }
            }

                for (int j = 0; j <= no; j++)
                {
                    Console.WriteLine(array[j]);
                }


            }
        }
    }
