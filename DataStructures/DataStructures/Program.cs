﻿using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter digits 1");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    TryLinkedList.TRY();
                    break;
                case 2:
                    UnOrderedList.LinkList();
                    break;
                default:
                    break;
            }





        }
    }
}