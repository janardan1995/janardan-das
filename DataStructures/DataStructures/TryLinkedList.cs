using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class TryLinkedList
    {
        
          
       public  class Node
     {
    public int data;
    public Node next;
    public Node(int d)
     {
        data = d;
        next = null;
      }       
            
     } 
         public static void TRY()
        {
            Node head = new Node(6);
            Node two = new Node(3);
            Node three = new Node(4);
            Node four = new Node(2);
            Node five = new Node(1);
            head.next = two;
            two.next = three;
            three.next = four;
            four.next = five;
            // Node n = head;
            //while (n!=null){
            //    Console.Write(n.data + " ");
            //    n = n.next;
            //}
           // push(40,head);
          
            //Node new_node = new Node(40);
            //new_node.next = head;
            //head = new_node;

         TryLinkedList ppp = new TryLinkedList();
         push(40,head);
           append(50, head);

            Console.Write("........................................... ");
            Node n = head;

            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }

        }
        public static void push(int new_data,Node head)
        {
            /* 1 & 2: Allocate the Node & 
                    Put in the data*/
            Node new_node = new Node(new_data);

            /* 3. Make next of new Node as head */
            new_node.next = head;

            /* 4. Move the head to point to new Node */
            head = new_node;
        }
        public static void append(int new_data,Node head)
        {
            Node new_node = new Node(new_data);

            if (head == null)
            {
                head = new Node(new_data);
                return;
            }

            new_node.next = null;

            
            Node last = head;
            while (last.next != null)
                last = last.next;

            /* 6. Change the next of last node */
            last.next = new_node;
            return;
        }

        }
}
