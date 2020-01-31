using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class ListOrder
    {
        public static void Order()
        {
            String filePath = @"C:\Users\Neelabh\Desktop\GitHub\dataStructure\DataStructures\DataStructures\orderll.txt";
            String text = System.IO.File.ReadAllText(filePath);
            Console.WriteLine(text);
            string[] str = text.Split(" ");
            int[] arr = new int[str.Length];
           
           
            for (int i = 0; i <str.Length; i++)
            {
                //Console.WriteLine(str[i]);
                arr[i] =int.Parse(str[i]);
            }

            MyLLForInt ll = new MyLLForInt();
            for(int i = 0; i <arr.Length; i++)
            {
                ll.AddInArrange(arr[i]);
            }
            ll.Display1();

            Console.WriteLine("enter the no that you wanna insert into the linked list");
            int x=int.Parse(Console.ReadLine());
            ll.AddInArrange(x);
            ll.Display1();
        }
    }
}
