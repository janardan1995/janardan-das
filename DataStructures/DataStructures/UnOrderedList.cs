//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DataStructures
//{
//    class UnOrderedList
//    {
//        public static void LinkList<T>()
//        {
//            //
//           //<string> unOrderedList = new  

//            string filePath = @"C:\Users\Neelabh\Desktop\GitHub\dataStructure\DataStructures\DataStructures\TextFile1.txt"; // or whatever the path is
//            String text = Utility<T>.FileElement(filePath);
//            String[] arr = text.Split(" ");

//            Node1<string> head=new Node1<string>(arr[0]);
//            head.next = null;
//            for (int i = 1; i < arr.Length; i++)
//            {
//                 Utility<string>.append((arr[i]),head);
//            }


//            Utility<string>.PrintLinkList(head);

//            Console.WriteLine("enter the no that you wanna search");
//            string x = Console.ReadLine();
//            bool temp = false;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                int y = x.CompareTo(arr[i]);

//                if (y == 0)
//                {
//                    temp = true;
                    
//                }
//            }
//            if (temp == true)
//            {
//                Console.WriteLine("item is found");
//                deleteNode<string>( x,  head);
//               // Utility.PrintLinkList(head);
//            }
//            else
//            {
//                AddingNode<string>( x, head);
//            }
           
//            //Utility.PrintLinkList(head);
//            StringBuilder strr = new StringBuilder();

//            while (head.next != null)
//            {
//                head = head.next;
//                strr.Append(head.data+" ");
               
//            }
//            string strr1 = strr.ToString();
//            Console.WriteLine(strr1);
//            System.IO.File.WriteAllText(@"C:\Users\Neelabh\Desktop\GitHub\dataStructure\DataStructures\DataStructures\TextFile1.txt", strr1);



//        }
//        public static void deleteNode<T>(T key,Node1<T> head)
//        {
//           // //Node head;
//           // // Store head node 
//           Node1<T> temp = head, prev = null;

//            // // If head node itself holds the key to be deleted 
//            //if (temp != null && temp.data != key)
//            //{
//            //    temp = temp.next; // Changed head 
//            //    return;
//            //}

//            // // Search for the key to be deleted, keep track of the 
//            // // previous node as we need to change temp.next 
//            while (temp != null && temp.data != key)
//            {
//                prev = temp;
//                temp = temp.next;
//            }

//            // // If key was not present in linked list 
//             if (temp == null) return;

//            // // Unlink the node from linked list 
//             prev.next = temp.next;
//        }
//        public static void AddingNode<T>(T key, Node1<T> head)
//        {
          
//              Node1<T> temp = head;

            
//            Node1<T> NewNode = new Node1<T>( key);
            
//            while ( temp.next!=null)
//            {
//                temp = temp.next;
                
//            }
//            temp.next = NewNode;
//            return;
           
//        }



//    }
//}
