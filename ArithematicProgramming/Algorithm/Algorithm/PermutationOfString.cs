﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class PermutationOfString
    {
        public static void Permu()
        {
            Console.WriteLine("Enter the string");
           String s= Console.ReadLine();
            char[] ch = s.ToCharArray();
            int currentIndex = 0;
            Utility.Permutation(ch, currentIndex);
            
        }   
      
    }
     
}
  
