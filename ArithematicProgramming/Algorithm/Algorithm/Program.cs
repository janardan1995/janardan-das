using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Functional programming");
            Console.WriteLine("----------------------");

            Console.WriteLine(" 1. All permutations of a String using iterative method and Recursion method");
            Console.WriteLine(" 2.Binary Search the Word from Word List");
            //Console.WriteLine(" 3.Leap Year");
            //Console.WriteLine(" 4.Harmonic Number ");
            //Console.WriteLine(" 5.Power of 2");
            //Console.WriteLine(" 6.Factors");
            //Console.WriteLine(" 7. 2D array");
            //Console.WriteLine(" 8. Sum of three Integer adds to ZERO");
            //Console.WriteLine(" 9.Euclidean distance from the point (x, y) to the origin (0, 0)");
            //Console.WriteLine(" 10.Write a program Quadratic.java to find the roots of the equation a*x*x + b*x + c.");
            //Console.WriteLine(" 11.Write a program WindChill.java ");
            //Console.WriteLine("12.Gamler game");
            //Console.WriteLine("13.Coupone Number");
            //Console.WriteLine("14.Stop watch");
            //Console.WriteLine("15.Tic Toe Tik");
            //Console.WriteLine("16.Vending Machine");
            //Console.WriteLine("17.dayOfWeeks");
            //Console.WriteLine("18.celcius to Ferhinheit and vic versa");
            //Console.WriteLine("19.Monthly pament");
            //Console.WriteLine("20.Newton method");
            //Console.WriteLine("21.Decimal to binary");
            //Console.WriteLine("22.swap nibble");



            int str = int.Parse(Console.ReadLine());
            switch (str)
            {
                case 1:
                    PermutationOfString.Permu();
                    break;
                case 2:
                    BinarySearch.Binary();
                    break;
                //case 3:
                //    LeapYear.Leap();
                //    break;
                //case 4:
                //    HarmonicNumber.Harmonic();
                //    break;
                //case 5:
                //    PowerOf2.Power();
                //    break;
                //case 6:
                //    FactorNumber.Factor();
                //    break;
                //case 7:
                //    TwoDArray.Two();
                //    break;
                //case 8:
                //    SumOfThree.Sum();
                //    break;
                //case 9:
                //    Distance.Dist();
                //    break;
                //case 10:
                //    Quadratic.Quad();
                //    break;
                //case 11:
                //    WindChill.Wind();
                //    break;
                //case 12:
                //    Gambler.Game();
                //    break;
                //case 13:
                //    Cupon_number.Cupon();
                //    break;
                //case 14:
                //    Stopwatchs.Stop();
                //    break;
                //case 15:
                //    TicTakTeo.Tic();
                //    break;
                //case 16:
                //    VendingMachine.Vending();
                //    break;
                //case 17:
                //    DaysOfWeek.Days();
                //    break;
                //case 18:
                //    TemperatureConversion.Temperature();
                //    break;
                //case 19:
                //    MonthlyPayment.Payment();
                //    break;

                default:
                    break;

            }


        }
    }
    }

