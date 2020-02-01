using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class MyQueue
    {
        public Node1 head;
        public class Node1
        {
            public string data;
            public Node1 next;
            public Node1(string data)
            {
                this.data = data;
                this.next = null;
            }
        }
        public void AddQueue()
        {
            Console.WriteLine("Name plzz");
            string x = Console.ReadLine();
            Node1 NewNode = new Node1(x);

            if (head == null)
            {
                head = NewNode;
            }
            else
            {
                Node1 temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = NewNode;

            }

        }
        public void DisplayQueue()
        {
            Node1 temp = head;
            int count = 0;
            Console.WriteLine("Display the queue");
            while (temp != null)
            {

                count++;
                Console.WriteLine("position " + count + " in queue : " + temp.data);
                temp = temp.next;
            }

        }
        public void DeleteQueue()
        {
            bool b = isQueueEmpty();
            if (b == true)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                if (head.next == null)
                {
                    head = null;
                }
                else
                {
                    head = head.next;

                }
            }
        }
        public bool isQueueEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public int WidORdip(int data)
        {
            Console.WriteLine("for Withdraw press w AND for Diposite press d");

            string x = Console.ReadLine();
            switch (x)
            {
                case "w":
                    Console.WriteLine("How much money you want to withdraw");
                    Console.WriteLine("Limit for withdraw is 10000 per person");
                    int y = int.Parse(Console.ReadLine());
                    data = data - y;
                    return data;

                case "d":
                    Console.WriteLine("How much money you want to Diposite");
                    Console.WriteLine("Limit for diposite is also 10000 per person");
                    int z = int.Parse(Console.ReadLine());
                    data = data - z;
                    return data;

                default:
                    Console.WriteLine("you have enter a wrong key");
                    WidORdip(data);
                    return data;


            }
        }
       public void isProcessComplete()
        {
            Console.WriteLine("Is banking process is complete : y/n");
            string x = Console.ReadLine();
            switch (x)
            {
                case "y":

                    DeleteQueue();
                    break;

                default:
                    break;

            }
        }
    }
}
