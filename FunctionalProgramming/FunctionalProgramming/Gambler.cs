﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class Gambler
    {
        public static void Game()
        {
            //Console.Write("Enter the stack");
            Utility.PrintLine("Enter the stack");
            int stack = Utility.UtiliReadInt();
            Utility.PrintLine("Enter the Goal");
            int goal = Utility.UtiliReadInt();
            Utility.PrintLine("Enter the no of time you wanna play this game");
            int no = Utility.UtiliReadInt();
            int win = 0;
            int loss = 0;
               
            for (int i=0;i<no;i++)
            {
                int count = 0;
               int  cash = stack;
                while (cash >0 && cash <goal)
                {
                    Random rand = new Random();
                    int x = rand.Next(0, 2);


                    if (x== 0)
                    {
                        cash--;
                        count++;
                    }
                    else if(x==1)
                    {
                        cash++;
                        count++;
                    }

                }
                if (cash == 0)
                {
                    Console.WriteLine("you broke");
                    loss++;
                }
                else if (cash == goal)
                {
                    Console.WriteLine("you win");
                    win++;
                }
                
                
            }
            Console.WriteLine("no of time you win : "+win);
            Console.WriteLine("no of time you loss :  "+loss);
            int winper = (win * 100) / no;
            int lossper = (loss * 100) / no;
            Console.WriteLine("percentage of win " + winper+"%");
            Console.WriteLine("percentage of loss " + lossper+"%");
        }
        
    }
}
