using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class BankingCashCounter
    {
        public static void Banking()
        {
            Console.WriteLine("How many no of people initially you added into the queue");
            int x = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Initial cash  that cashier have");
            int balanch = int.Parse(Console.ReadLine());
            MyQueue qq = new MyQueue();
            while (x > 0)
            {
                qq.AddQueue();
                int data=qq.WidORdip(balanch);
                if (data< 0)
                {
                    Console.WriteLine("NO farther transition ! soory for that");
                    Environment.Exit(0);
                }
                qq.isProcessComplete();
                qq.DisplayQueue();
                x--;
            }
        }
    }
}
