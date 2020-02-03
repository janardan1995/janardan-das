using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class PrimeAnagram1
    {
        public static void PA()
        {
            LinkedList2 a = new LinkedList2();

            
            for (int i = 2; i <= 1000; i++)
            {
                if (isprimeNo(i) == true)
                {
                    a.Add(i);
                }
            }
            a.Display();
            Console.WriteLine("_________________________________________");
            a.Aaanna();



        }
        public static bool Anagram(int no1, int no2)
        {
            if (no1 == no2 )
            {
                return false;
            }
            else {
                string xx = no1.ToString();
                string xxx = no2.ToString();
                int aaa = xx.Length;
                int bbb = xxx.Length;
                if (aaa == bbb)
                {
                    int[] arr = new int[10];
                    int num = no1;
                    int num1 = no2;
                    for (int i = 0; i < 10; i++)
                    {
                        arr[i] = 0;
                    }
                    while (num > 0)
                    {
                        int n = num % 10;
                        arr[n]++;
                        num = num / 10;
                    }

                    while (num1 > 0)
                    {
                        int n1 = num1 % 10;
                        arr[n1]--;
                        num1 = num1 / 10;

                    }
                    for (int i = 0; i < 10; i++)
                    {
                        if (arr[i] != 0)
                        {
                            return false;
                        }


                    }
                    return true;
                }
                else
                {
                    return false;
                }

            } }
        
        public static bool isprimeNo(int no)
        {
            int count = 0;
            for (int i = 1; i <= no; i++)
            {
                if (no % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    
}