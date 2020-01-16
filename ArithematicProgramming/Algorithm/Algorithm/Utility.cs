using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Utility
    {
        public static void Permutation(char[] ch, int currentIndex)
        {
            if (currentIndex == ch.Length - 1)
            {
                Console.WriteLine(ch);
            }
            for (int i = currentIndex; i < ch.Length; i++)
            {
                Swap(ch, currentIndex, i);
                Permutation(ch, currentIndex + 1);
                Swap(ch, currentIndex, i);
            }

        }
        public static void Swap(char[] ch, int currentindex, int i)
        {
            char temp = ch[currentindex];
            ch[currentindex] = ch[i];
            ch[i] = temp;
        }
        // for convert file to string
        public static string FileElement(string filePath)
        {
            string text = System.IO.File.ReadAllText(filePath);
            Console.WriteLine(text);
            return text;

        }

        // for binary search...........................
        public static int BinarySearc(String[] s1, String x)
        {
            int l = 0, r = s1.Length;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                int res = x.CompareTo(s1[m]);

                // Check if x is present at mid
                if (res == 0)
                    return m;


                // If x greater, ignore left half
                if (res > 0)
                    l = m + 1;

                // If x is smaller, ignore right half
                else
                    r = m - 1;
            }

            return -1;
        }
    }
    //
    class MergeSortTest
    {
        int[] array;
        int[] tempMargeArr;
        int length;
        public void Sort(int[] inputArr)
        {
            this.array = inputArr;
            this.length = inputArr.Length;
            this.tempMargeArr = new int[length];

            DivideArray(0, length - 1);
        }


        public void DivideArray(int lowerIndex, int higherIndex)
        {
            if (lowerIndex < higherIndex)
            {
                int middle = lowerIndex + (higherIndex - lowerIndex) / 2;

                //it will sort the left side of an arr
                DivideArray(lowerIndex, middle);
                //it will sort the right side of an arr
                DivideArray(middle + 1, higherIndex);
                // we have to marge the divide array
                MergeArray(lowerIndex, middle, higherIndex);
            }

        }
        public void MergeArray(int lowerIndex, int middle, int higherIndex)
        {
            

            for (int a = lowerIndex; a <= higherIndex; a++)
            {
                tempMargeArr[a] = array[a];
            }

            int i = lowerIndex;
            int j = middle + 1;
            int k = lowerIndex;

            while (i <= middle && j <= higherIndex)
            {
                if (tempMargeArr[i] <= tempMargeArr[j])
                {
                    array[k] = tempMargeArr[i];
                    i++;

                }
                else
                {
                    array[k] = tempMargeArr[j];
                    j++;
                }
                k++;
            }
            while (i <= middle)
            {
                array[k] = tempMargeArr[i];
                k++;
                i++;
            }
        }
       
    }
}