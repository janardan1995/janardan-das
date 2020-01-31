using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class MyStack
    {
        public Node1 head;
        public class Node1
        {
            public String data;
            public Node1 next;
            public Node1(String x)
            {
                this.data = x;
                this.next = null;
            }
        }
        public void StackPush(String data)
        {
            Node1 NewNode = new Node1(data);
            if (head == null)
            {
                head = NewNode;
            }
            else
            {
               NewNode.next=head;
               
            }
            Console.WriteLine("{0} pushed to stack",data);
            head = NewNode;

        }
        public bool IsStackEmpty()
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
        public string StackPop()
        {
            bool b = IsStackEmpty();
            if (b == true)
            {
                Console.WriteLine("stack is empty");
                return null;
            }
            else
            {
                string x = head.data;
                head = head.next;
                return x;
            }
        }
        public void DisplayStack()
        {
            Node1 temp = head;
            while (temp!= null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
          
        }
    }
}
