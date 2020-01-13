﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class Cupon_number
    {
		public static void Cupon()
		{
			Console.WriteLine("How hamy distinct coupon number required");
			char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789".ToCharArray();
			int max = 100000000;
			int number = Utility.UtiliReadInt();
			Random rand = new Random();
			
			int j = 0;
			int no=number;
			String[] arr = new String[no];

			for (int i = 0; i < no; i++)
			{		
				var sb = new StringBuilder();
				int random = (int)(rand.Next() * max);
				if (random > 0)
				{
					while (random > 0)
					{
						sb.Append(chars[random % chars.Length]);
						random /= chars.Length;
					}
					String couponCode = sb.ToString();
					if (i == 0)
					{
						arr[0] = couponCode;
						j++;						
					}
					else
					{
						if (couponCode == arr[j - 1])
						{
							no = no + 1;
						}
						else
						{
							arr[j] = couponCode;
							j++;
						}
					}
				}
				else
				{
					no++;
				}
			}
			for (int k = 0; k < number; k++)
			{
				Console.WriteLine(arr[k]);
			}	
		}
	}
    }
