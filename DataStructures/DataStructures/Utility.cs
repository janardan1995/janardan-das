using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Utility
    {
        public int HashFunction(int data)
        {
            int x = data % 11;
            return x;
        }
    }
    //for anagramPrine no
   
    public class LinkedList2
    {
        Node11 head;
        public class Node11
        {
            public int data;
            public Node11 next;
            public Node11(int data)
            {

                this.data = data;
                this.next = null;
            }
        }
        public void Add(int no)
        {
            Node11 NewNode = new Node11(no);
            if (head == null)
            {
                head = NewNode;
            }
            else
            {
                Node11 temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = NewNode;

            }
        }
        public void Display()
        {
            Console.WriteLine("displaing Linked list.............................................. ");
            Node11 temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        //stack
        public  void AddinStake(int data)
        {
            Node11 temp = head;
            Node11 NewNode = new Node11(data);
            if (head == null)
            {
                head = NewNode;

            }
            else
            {
                NewNode.next = head;
                head = NewNode;
            }
        }

        //queue
        public void AddiQueue(int data)
        {
            
            Node11 NewNode = new Node11(data);
            if (head == null)
            {
                head = NewNode;

            }
            else
            {
                Node11 temp = head;
                while (temp.next != null)
                {
                    
                    temp = temp.next;
                }
                temp.next = NewNode;
            }
        }





        //anagram logic

        public void Aaanna()
        {
            PrimeAnagram1 pp = new PrimeAnagram1();
            LinkedList2 b = new LinkedList2();

            LinkedList2 c = new LinkedList2();
            LinkedList2 d = new LinkedList2();
            Node11 temp = head;
            while (temp != null)
            {
                //at first temp.data go to anagram method
                Node11 n = head;
                while (n != null)
                {
                    //i have used 2 loops for anagram and  
                    if (PrimeAnagram1.Anagram(temp.data, n.data) == true)
                    {
                        //add the data in linked list
                        b.Add(temp.data);
                        //add the data into the queue
                        c.AddinStake(temp.data);
                        //add the linked list using queue
                        d.AddiQueue(temp.data);
                        break; 
                        
                    }
                    
                    
                   
                    n = n.next;
                }
                temp = temp.next;
            }
            Console.WriteLine("prime and anagram................>");
            b.Display();
            Console.WriteLine("prime and anagram in reverse order using stack................>");
            c.Display();
            Console.WriteLine("prime and anagram in using queue................>");
            d.Display();
           
        }
    }
    
}
