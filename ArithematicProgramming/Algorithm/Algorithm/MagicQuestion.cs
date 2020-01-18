using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class MagicQuestion
    {
        public static void Magic()
        {
            Console.WriteLine("thing a number from 0 to your choice");
            Console.WriteLine("type the last boundary as your wish");
            int x = int.Parse(Console.ReadLine());

            int lowerIndex = 0;
            int higherIndex = x;

            while (lowerIndex <= higherIndex)
            {

                int midIndex = ((lowerIndex + higherIndex) / 2)-1;



                Console.WriteLine("is your no in between " + lowerIndex + " to " + (midIndex-1) + " just type true and false");
                String b = Console.ReadLine();

                if (b == "T" || b == "t")
                {
                    higherIndex = midIndex;
                }
                else
                {
                    lowerIndex = midIndex;
                }
                if (lowerIndex==higherIndex)
                {
                    Console.WriteLine("your no is {0}", midIndex);
                    break;

                }

            }
        }
    }
}
