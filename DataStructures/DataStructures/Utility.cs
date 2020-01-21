using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    //created a node 
    public class Node
    {
        public String data;
        public Node next;
        public Node(string d)
        {
            data = d;
            next = null;
        }
    }

    //my utility class is here
    class Utility
    {
        //to print the elements of a linked list.....>
        public static void PrintLinkList(Node head)
        {
            Node n = head;
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.next;
            }

        }
        //file path
        public static String FileElement(String filePath)
        {
            String text = System.IO.File.ReadAllText(filePath);
            Console.WriteLine(text);
            return text;
        }
        public static void append(String new_data, Node head)
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
