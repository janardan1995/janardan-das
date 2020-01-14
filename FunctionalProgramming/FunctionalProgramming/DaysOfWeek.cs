using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class DaysOfWeek
    {
        public static void Days()
        {
            Console.WriteLine("enter the date in dd/mm/yyyy");
            String a = Utility.UtiliRead();
            String[] str = a.Split("/");
            int[] arr = new int[str.Length];
            for(int i = 0; i < str.Length; i++)
            {
                arr[i] =int.Parse(str[i]);
            }      
            int day = arr[0];
            int month = arr[1];
            int year = arr[2];
            Console.WriteLine("you haved entered the day={0} ,month={1} ,year={2}", day, month, year);
            int da1 = Utility.GetTheDay(year, month, day);
            Utility.Get(da1);
           
        }
       
        

        }
    }

