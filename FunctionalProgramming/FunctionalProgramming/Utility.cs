﻿//<auto-generated/>
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class Utility
    {
        //for Console.Write here normal string is return
        public static void PrintLine(String x)
        {
            Console.WriteLine(x);
        }
        //for Console.Write here integer is return
        public static int UtiliReadInt()
        {
            int x = int.Parse(Console.ReadLine());
            return x;
        }
        //for Console.Write here Double integer is return
        public static double UtiliReadDouble()
        {
            int x = int.Parse(Console.ReadLine());
            return x;
        }
        //no use of it 
        public static String UtiliRead()
        {
            String x = Console.ReadLine();
            return x;
        }
        public static void PrintArray(double[] value, int no)
        {

            for (int j = 0; j <= no; j++)
            {
                Console.WriteLine(value[j]);
            }

        }
        // leapYear logic that i have created
        public static Boolean UtiliLeapYear(int year)
        {
            if (year >= 1752 && year <= 9999)
            {
                if (year % 4 == 0 || year % 400 == 0 && year % 100 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Console.WriteLine("invalide year");
            }
            return false;

        }
        //windchill
        public static double WindChill(int t, double v)
        {

            double w = 35.74 + 0.6215 * t + (0.4275 * t - 35.75) * Math.Pow(v, 0.16);


            return w;
        }
        //for stop watch
        public static int[] Time(int x)
        {

            String x1 = DateTime.Now.ToLongTimeString().ToString();
            char[] spearator = { ':', ' ' };
            String[] st1 = x1.Split(spearator);
            int[] arr1 = new int[3];

            for (int i = 0; i < 3; i++)
            {
                arr1[i] = int.Parse(st1[i]);
            }

            //Console.WriteLine("Enter 1 to stop");
            //int stop = int.Parse(Console.ReadLine());
            return arr1;
        }
        public static void PrintArray(String[,] value, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(value[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        //for tic tak teo game random
        public static int Random1()
        {
            //random number generator
            Random rand = new Random();
            int x = rand.Next(1, 10);
            return x;
        }
        // for weeksof the day Switch ase
        public static void Get(int d)
        {
            switch (d)
            {
                case 0:
                    Console.WriteLine("sunday");
                    break;
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursdayday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                default:
                    break;

            }
        }

        //for count the first day of the month its return 0-6
        public static int GetTheDay(int year, int month, int day)
        {
            int y = year - (14 - month) / 12;
            int x = y + y / 4 - y / 100 + y / 400;
            int m = month + 12 * ((14 - month) / 12) - 2;
            int d = (day + x + (31 * m) / 12) % 7;
            return d;

        }
    }
}
