using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Anagram
    {
        public static void Ana()
        {
            //first no.
            String str1 = Utility.CallingAWord();
            char[] first = new char[str1.Length];
            first = str1.ToCharArray();
            //second number
            String str2 = Utility.CallingAWord();
            char[] second = new char[str2.Length];
            second = str2.ToCharArray();
            Utility.AnagramTest(first, second);
            //assign an array of lenfth 26 such that i have to enter all the 26 no. on that.
        }
           
       
    }
}
