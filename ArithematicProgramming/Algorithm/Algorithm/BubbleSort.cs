using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class BubbleSort
    {
        public static void Bubble()
        {
            Console.WriteLine("Enter the number of element you shouid enter into  the array ");
            int l = int.Parse(Console.ReadLine());
            int[] array = new int[l];
            Utility.Bubble1(array);
        }
        
    }
}


  

