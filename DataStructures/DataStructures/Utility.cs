using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
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
    }
}
