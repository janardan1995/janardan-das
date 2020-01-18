using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class PrimeAnagramPalindrome
    {
        public static void PrimeNo()
        {


            int[] arr = new int[200];
            //asign 0 to all the element in arr
            //
            int k = 0;
            //
            for (int i = 2; i < 1000; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {

                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    arr[k] = i;

                    k++;
                }
            }


            Console.WriteLine("numbers" + "........." + "palindrome number");
            int s = 0;
            while (arr[s] > 0)
            {
                if (arr[s] == Utility.Reverse(arr[s]))
                {

                    Console.WriteLine(arr[s] + "................" + Utility.Reverse(arr[s]));

                }
                s++;
            }
            Console.WriteLine("__________________________________");


            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine(arr[i]);
            }

                //for anagram no.
                int[] arrNo = new int[10];

            for (int i = 0; i < 10; i++)
            {

                //initially i put 0 to all element
                arrNo[i] = 0;
            }


            for (int i = 0; i < arr.Length; i++)
            {
                

                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        String st1 = arr[i].ToString();
                        String st2 = arr[j].ToString();
                        if (st1.Length != st2.Length)
                        {
                            break;
                        }
                        else
                        {

                            int x = arr[i];
                            while (x > 0)
                            {
                                int y = x % 10;

                                arrNo[y]++;
                                x = x / 10;
                            }
                            int xy = arr[j];

                            while (xy > 0)
                            {
                                int yy = xy % 10;

                                arrNo[yy]--;
                                xy = xy / 10;
                            }

                            for (int l = 0; l < 10; l++)
                            {
                                if (arrNo[i] != 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine(arr[i] + " anagram of " + arr[j]);
                                }
                            }
                        }
                    }  }
                }
            }
        
}

