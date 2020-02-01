//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DataStructures
//{
//    class OrderList<T>
//    {

//        public static void Order()
//        {
//            String filePath = @"C:\Users\Neelabh\Desktop\GitHub\dataStructure\DataStructures\DataStructures\TextFile1.txt";
//            string text = System.IO.File.ReadAllText(filePath);
//            string[] arr = text.Split(" ");
//            Node head = null;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                addingNodeSorted(int.Parse(arr[i]),head);

//            }





//        }
//        public static void addingNodeSorted(int x,Node head)
//        {

//            Node newNode = new Node(x);
//            Node temp = head;
//            if ( head == null)
//            {
//                head.data = x;
//                head.next = null;

//            }
//            else
//            {
//                while (temp.next != null)
//                {

//                }
//                temp.next = newNode;
//            }

//        }
//    }
//}
