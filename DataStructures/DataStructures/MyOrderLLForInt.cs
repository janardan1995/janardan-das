using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class MyLLForInt
    {
        public Node1 head;
        public class Node1
        {
            public int data;
            public Node1 next;
            public Node1(int d)
            {
                data = d;
                next = null;
            }

        }
        //add in arange order
        public void AddInArrange(int data)
        {
           
          
            Node1 NewNode = new Node1(data);
            if (head == null || head.data >=NewNode.data)
            {
                NewNode.next = head;
                head = NewNode;
                return;
            }
            else
            {
                Node1 n = head;
                while (n.next != null && n.next.data < NewNode.data)
                {
                    n = n.next;
                    
                }

                   NewNode.next = n.next;
                   n.next = NewNode;
                
            }


        }








        //add in the last
        public void AddLast(int data)
        {
            Node1 newNode = new Node1(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node1 n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = newNode;
            }
        }
        //add in first
        public void AddFirst(int data)
        {
            Node1 NewNode = new Node1(data);
            NewNode.next = head;
            head = NewNode;
        }
        //display the linked list or print
        public void Display1()
        {
            Console.WriteLine("Linklist elements are");
            Node1 temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        //delete the element from the linked list if the data is given
        public void DeleteLL(int data)
        {

            // Store head node 
            Node1 temp = head, prev = null;

            // If head node itself holds the key to be deleted 
            if (temp != null && temp.data == data)
            {
                head = temp.next; // Changed head 
                return;
            }

            // Search for the key to be deleted, keep track of the 
            // previous node as we need to change temp.next 
            while (temp != null && temp.data != data)
            {
                prev = temp;
                temp = temp.next;
            }

            // If key was not present in linked list 
            if (temp == null) return;

            // Unlink the node from linked list 
            prev.next = temp.next;

        }
        //checking whether the element are present on the link list or not
        public bool CheckLL(int data)
        {
            Node1 temp = head;
            if (temp != null && temp.data == data)
            {
                Console.WriteLine("element is found");
                return true;
            }
            while (temp != null && temp.data != data)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("element not found");
                return false;
            }
            else
            {
                Console.WriteLine("element found");
                return true;
            }
        }
        //adding the linklist to a given string
        public void WriteFile()
        {
            StringBuilder sb = new StringBuilder();
            Node1 temp = head;
            while (temp != null)
            {
                sb.Append(temp.data + " ");
                temp = temp.next;
            }
            string sb1 = sb.ToString();
            System.IO.File.WriteAllText(@"C:\Users\Neelabh\Desktop\GitHub\dataStructure\DataStructures\DataStructures\TextFile1.txt", sb1);

        }

    }
}
