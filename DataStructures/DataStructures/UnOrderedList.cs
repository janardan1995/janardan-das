using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class UnOrderedList
    {
        public static void  LinkList()
        {
            Node head = new Node(1);
            
            Node x = new Node(4);
            head.next = x;
            Utility.PrintLinkList(head);
        }


    }
}
