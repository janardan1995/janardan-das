using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class BinarySearch
    {
        public static void Binary()
        {
            string filePath = @"C:\Users\Neelabh\Desktop\GitHub\File.txt"; // or whatever the path is
            String text = Utility.FileElement(filePath);
            string[] words = text.Split(" ");

            Console.WriteLine("enter the no. that you wanna search");
            String x = Console.ReadLine();
            int result = Utility.BinarySearc(words, x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at "
                        + "index " + result);
        }
      

    }
}

