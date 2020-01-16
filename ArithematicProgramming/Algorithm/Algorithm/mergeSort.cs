using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class MergeSort
    {       
        public static void Merge1()
        {
           
            Console.WriteLine("Enter how many that you wanna sort");
            int x=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter all the no.s that you wanna sort");
            int[] inputArr = new int[x];
            for(int i = 0; i < x; i++)
            {
                inputArr[i] = int.Parse(Console.ReadLine());
            }

           MergeSortTest ob = new MergeSortTest();
            ob.Sort(inputArr);

          Console.WriteLine("\nSorted array");
            foreach (int i in inputArr)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}




