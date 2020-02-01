using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Hashing
    {
        public static void Hash()
        {
            string newpath = @"C:\Users\Neelabh\Desktop\GitHub\dataStructure\DataStructures\DataStructures\orderll.txt";
            string x = System.IO.File.ReadAllText(newpath);
            string[] str = x.Split(" ");
            int len = str.Length;
            int[] arr = new int[len];
            //store all the elements into an int arr from the list
            for (int i = 0; i < len; i++)
            {
                arr[i] = int.Parse(str[i]);
            }

            //now create a arr of size 10 for store those elements
            IntLL ll = new IntLL();
            IntLL.Node2[] arr1 = new IntLL.Node2[11];


            //so create a linked list for every arr index
            IntLL a = new IntLL();
            IntLL b = new IntLL();
            IntLL c = new IntLL();
            IntLL d = new IntLL();
            IntLL e = new IntLL();
            IntLL f = new IntLL();
            IntLL g = new IntLL();
            IntLL h = new IntLL();
            IntLL j = new IntLL();
            IntLL k = new IntLL();

            IntLL m = new IntLL();


            //...................................
            Utility uu = new Utility();
            for (int i = 0; i < len; i++)
            {

                int xx = uu.HashFunction(arr[i]);
                //i have used this one for create 11 linked list
                switch (xx)
                {
                    case 0:

                        arr1[xx] = a.AddLast(arr[i]);

                        break;
                    case 1:

                        arr1[xx] = b.AddLast(arr[i]);
                        break;
                    case 2:

                        arr1[xx] = c.AddLast(arr[i]);
                        break;
                    case 3:

                        arr1[xx] = d.AddFirst(arr[i]);
                        break;
                    case 4:

                        arr1[xx] = e.AddLast(arr[i]);
                        break;
                    case 5:

                        arr1[xx] = f.AddLast(arr[i]);
                        break;
                    case 6:

                        arr1[xx] = g.AddLast(arr[i]);
                        break;
                    case 7:

                        arr1[xx] = h.AddLast(arr[i]);
                        break;
                    case 8:

                        arr1[xx] = j.AddLast(arr[i]);
                        break;
                    case 9:

                        arr1[xx] = k.AddLast(arr[i]);
                        break;
                    case 10:


                        arr1[xx] = m.AddLast(arr[i]);
                        break;
                    default:
                        break;

                }

            }
            a.Display(0);
            b.Display(1);
            c.Display(2);
            d.Display(3);
            e.Display(4);
            f.Display(5);
            g.Display(6);
            h.Display(7);
            j.Display(8);
            k.Display(9);

            m.Display(10);

        }
    }
}
