using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class VendingMachine
    {
        public static void Vending()
        {
            Console.Write("enter the change");
            int change = Utility.UtiliReadInt();
            int[] arr = { 1, 2, 5, 10, 50, 100, 500, 1000 };
            int i = arr.Length-1;
            while (i >=0)
            {
                int count = 0;
                if (change == arr[i])
                {
                    count++;
                    Console.WriteLine("{0} numbers of {1} note", count, arr[i]);
                    Environment.Exit(0);
                }
                while (change >= arr[i])
                {                   
                  if (change == arr[i])
                    {
                        count++;
                        Console.WriteLine("{0} numbers of {1} note", count, arr[i]);
                        Environment.Exit(0);
                    }
                    count++;
                    change -= arr[i];                    
                }
                Console.WriteLine("{0} numbers of {1} note", count, arr[i]);
                i--;
                
            }
        }
    }
}
