using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class PrimeNoRange
    {
        public static void Prime()
        {
            Console.WriteLine("the range of integer from 0 to 1000");

            IntLL.Node2[] arr = new IntLL.Node2[10];
            //so create a linked list for each range our range is 10 ,that's why taken 10.
            IntLL a = new IntLL();
            IntLL b = new IntLL();
            IntLL c = new IntLL();
            IntLL d = new IntLL();
            IntLL e = new IntLL();
            IntLL f = new IntLL();
            IntLL g = new IntLL();
            IntLL h = new IntLL();
            IntLL l = new IntLL();
            IntLL k = new IntLL();
            for (int i = 2; i <= 1000; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                    //prime no is comming...so now we have to store the no in the range 
                    if (count == 2)
                    {
                        //if no is lies between 0-99
                        if(i>=2 && i <= 99)
                        {
                           
                           arr[0]= a.AddLast(i);
                           
                        }
                        if(i>=100 && i <=199)
                        {
                            arr[1]=b.AddLast(i);
                        }
                         if(i>=200 && i <=299)
                        {
                           arr[2]= c.AddLast(i);
                        } 
                        if(i>=300 && i <=399)
                        {
                            arr[3]=d.AddLast(i);
                        }
                        if(i>=400 && i <=499)
                        {
                           arr[4]= e.AddLast(i);
                        }
                        if(i>=500 && i <=599)
                        {
                           arr[5]= f.AddLast(i);
                        }
                        if(i>=600 && i <=699)
                        {
                           arr[6]= g.AddLast(i);
                        }
                        if(i>=700 && i <=799)
                        {
                           arr[7]=h.AddLast(i);
                        }
                        if(i>=800 && i <=899)
                        {
                           arr[8]=k.AddLast(i);
                        }
                        if(i>=900 && i <=1000)
                        {
                           arr[9]= l.AddLast(i);
                        }                                                                                                                                       
                     }
                }
            
            a.Display(100);
            b.Display(200);
            c.Display(300);
            d.Display(400);
            e.Display(500);
            f.Display(600);
            g.Display(700);
            h.Display(800);
            k.Display(900);
           
            l.Display(1000);
        }
    }
}
