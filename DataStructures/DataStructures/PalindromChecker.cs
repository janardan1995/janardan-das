using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class PalindromChecker
    {
        public static void palindrome()
        {
            MyStack ss = new MyStack();
            Console.WriteLine("give me a string");
            string str = Console.ReadLine();
            //convert string into character array ie split into individual character
            char[] ch = str.ToCharArray();
            //then conver char array to string array
            String[] str2 = new string[str.Length];

            for (int i = 0; i < str.Length; i++)
            {

                str2[i] = ch[i].ToString();
            }
            //push the array of string into the stack 
            for (int i = 0; i < str.Length; i++)
            {
                ss.StackPush(str2[i]);
            }
            // get the character from the stack and then compare

            string c = ss.AbstractFStack();

            int cc = c.CompareTo(str);
            if (cc == 0)
            {
                Console.WriteLine("given string is a palindrome");
            }
            else
            {
                Console.WriteLine("given string is not a palindrome");
            }
        }
    }
}
