﻿//<auto-generated/>
using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to datastructure programming");
            Console.WriteLine("1.Unorder list");
            Console.WriteLine("2.Order list");
            Console.WriteLine("3.Balanched parentheses");
            Console.WriteLine("4.Banking cash counter program");
            Console.WriteLine("5.Palindrom Checker");
            Console.WriteLine("6.Hashing");
            Console.WriteLine("7.Prime no range");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Unorderlist.Unorder();
                    break;
                case 2:
                    ListOrder.Order();
                    break;
                case 3:
                    BalanchedParentheses.Parentheses();
                    break;
                case 4:
                    BankingCashCounter.Banking();
                    break;
                case 5:
                    PalindromChecker.palindrome();
                    break;
               case 6:
                    Hashing.Hash();
                    break;
                case 7:
                    PrimeNoRange.Prime();
                    break;
               
                default:
                    break;
            }





        }
    }
}
