using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class BalanchedParentheses
    {
        public static void Parentheses()
        {
            Console.WriteLine("entre the arithematic operation");
            string str = Console.ReadLine();
            char[] x = str.ToCharArray();
            
            int y = x.Length;
            string[] s = new string[y];
            //
            for (int i = 0; i < y; i++)
            {
                s[i] = x[i].ToString();
            }
            //
            MyStack ss = new MyStack();
            for(int i = 0; i < y; i++)
            {
               // Console.Write(x[i] + " ..");
               if(s[i]=="[" || s[i]=="(" || s[i]=="{")
                {
                    ss.StackPush(s[i]);
                }
                else if (s[i] == "]" || s[i] == ")" || s[i] == "}")
                {
                    bool b = ss.IsStackEmpty();
                    if (b == true)
                    {
                        Console.WriteLine("unbalanced1");
                        Environment.Exit(0);
                    }
                    else
                    {
                       string com= ss.StackPop();
                        if (com == "{" && s[i]=="}" || com == "[" && s[i] == "]" || com == "(" && s[i] == ")")
                        {
                           
                            
                        }
                        else
                        {
                            Console.WriteLine("unbalanced3");
                            Environment.Exit(0);
                        }
                    }
                }
                
            }
            bool b1 = ss.IsStackEmpty();
            if (b1 == true)
            {
                Console.WriteLine("balanced");
            }
            else
            {
                Console.WriteLine("unbalanced");
            }

        }
       
    }
}
