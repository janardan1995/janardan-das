using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class UnOrderedList
    {
        public static void LinkList()
        {
            //

            string filePath = @"C:\Users\Neelabh\Desktop\GitHub\dataStructure\DataStructures\DataStructures\TextFile1.txt"; // or whatever the path is
            String text = Utility.FileElement(filePath);
            String[] arr = text.Split(" ");

            Node head=new Node((arr[0]));
            head.next = null;
            for (int i = 1; i < arr.Length; i++)
            {
                 Utility.append((arr[i]),head);
            }


            Utility.PrintLinkList(head);

            Console.WriteLine("enter the no that you wanna search");
            String x = Console.ReadLine();
            bool temp = false;
            for (int i = 1; i < arr.Length; i++)
            {
                int y = x.CompareTo(arr[i]);

                if (y == 0)
                {
                    temp = true;
                    
                }
            }
            if (temp == true)
            {
                Console.WriteLine("item is found");
                deleteNode(x, head);
            }
            else
            {
                AddingNode(x, head);
            }
           
            Utility.PrintLinkList(head);
            StringBuilder strr = new StringBuilder();

            while (head.next != null)
            {
                head = head.next;
                strr.Append(head.data+" ");
               
            }
            string strr1 = strr.ToString();
            System.IO.File.WriteAllText(@"C:\Users\Neelabh\Desktop\GitHub\dataStructure\DataStructures\DataStructures\TextFile1.txt", strr1);



        }
        public static void deleteNode(string key,Node head)
        {
           // //Node head;
           // // Store head node 
           Node temp = head, prev = null;

            // // If head node itself holds the key to be deleted 
            if (temp != null && temp.data == key)
            {
                head = temp.next; // Changed head 
                return;
            }

            // // Search for the key to be deleted, keep track of the 
            // // previous node as we need to change temp.next 
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }

            // // If key was not present in linked list 
             if (temp == null) return;

            // // Unlink the node from linked list 
             prev.next = temp.next;
        }
        public static void AddingNode(string key, Node head)
        {
          
            Node temp = head, prev = null;

            
            Node NewNode = new Node(key);
            
            while ( temp.next!=null)
            {
                temp = temp.next;
                
            }
            temp.next = NewNode;
            return;
           
        }



    }
}
