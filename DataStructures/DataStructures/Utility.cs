using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Utility
    {
        public int HashFunction(int data)
        {
            int x = data % 11;
            return x;
        }
    }
}
