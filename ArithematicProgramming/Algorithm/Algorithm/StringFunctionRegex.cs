using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Algorithm
{
    class StringFunctionRegex
    {
        public static void ReplaceNo()
        {                 
            String s1 = "Hello <<name>>, We have your full name as <<full name>> in our system. your contact number is 91-xxxxxxxxxx. Please,let us know in case of any clarification Thank you BridgeLabz 01/01/2016. Use Regex to replace name, full name, Mobile#, and Date with proper value.";
            
            //take name from the user

there:      Console.WriteLine("enter your full name");
            String fullName = Console.ReadLine();  

            //is user name is valide or not.
            if (Utility.isValidUserName(fullName) != true)
            {
                Console.WriteLine("invalide try again");
                goto there;
            }
                                 
            String[] strArr = new string[2];
            strArr = fullName.Split(" ");

            //replace the full name and name 
            String replaceName = s1.Replace("<<name>>", strArr[0]);
            String replaceFullName = replaceName.Replace("<<full name>>", fullName);
            

            //taking mobile no. from the user
Here:            Console.WriteLine("enter your mobile no.");
            String mobileNo = Console.ReadLine();          
                
            //is mobile no is valide or not.
                if (Utility.isValidMobileNumber(mobileNo) != true)
                {
                 Console.WriteLine("invalide try again");
                goto Here;
                }                       
           
            //replace the mobile number
            String replaceMobile = replaceFullName.Replace("xxxxxxxxxx", mobileNo);


            

            
            //taking DOB from user
    hher:   Console.WriteLine("enter your date of birth");
            String DOB = Console.ReadLine();

            if (Utility.isValidDOB(DOB) != true)
            {
                Console.WriteLine("invalide try again");
                goto hher;
            }
            String replaceDOB = replaceMobile.Replace("01/01/2016", DOB);
            Console.WriteLine(replaceDOB);
            // String replaceMobile1 = Regex.Replace();

            // String replaceDob = s1.Replace("<<name>>",strArr[0]);

        }
        
    }
}
