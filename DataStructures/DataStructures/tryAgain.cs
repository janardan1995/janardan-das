//using System;
//using System.Collections.Generic;
//using System.Text;
////using 


//namespace DataStructures
//{
//    class tryAgain
//    {
		
//			//Reading string from file
//			public Node readFile(Node start)
//			{
//				try
//				{
//				string filePath = @"C:\Users\Neelabh\Desktop\GitHub\File.txt"; // or whatever the path is
//				String fis = Utility.FileElement(filePath);
				
//					String[] wordsArray = fis.Split(" ");
//					for (int i = 0; i < wordsArray.Length; i++)
//					{
//						start = addWordstoList(start, wordsArray[i]);
//					}
//				}
//				catch (NullPointerException ne)
//				{
//					Console.WriteLine(ne);
//				}
//				catch (IOException e)
//				{
//				}
//				return start;
//			}//End of read method

//			//Insert words...........
//			public Node addWordstoList(Node node1, String str)
//			{
//				Node node2 = node1;
//				Node newNode = new Node();
//				newNode.data1 = str;
//				newNode.nextNode = null;
//				if (node1 == null)
//				{
//					return newNode;
//				}
//				else
//				{
//					while (node1.nextNode != null)
//					{
//						node1 = node1.nextNode;
//					}
//					node1.nextNode = newNode;
//				}
//				return node2;
//			}//End of insert method

//			//Search words
//			public static  searchData(Node node, String word)
//			{
//				Node temp = node;
//				while (node.nextNode != null)
//				{
//					if (word.compareTo((node.nextNode).data1) == 0)
//					{
//						node.nextNode = (node.nextNode).nextNode;
//					Console.WriteLine("Word is Found");
//					Console.WriteLine("the founded word is deleted from the file");
//					Console.WriteLine("file saved");
//						return temp;
//					}
//					node = node.nextNode;
//				}
//				Console.WriteLine("Word is not Found");
//			Console.WriteLine("the not founded word is added to the file");
//			Console.WriteLine("file saved");
//				temp = addWordstoList(temp, word);
//				return temp;
//			}//End of Search word

//			//writeToFile
//			public void writeDataToFile(String nWord)
//			{
//				try
//				{
//					File fi = new File("/home/bridgeit/Documents/Data/data.txt");
//					fi.createNewFile();
//					FileWriter fw = new FileWriter(fi);
//					fw.write(nWord);
//					fw.close();
//				}
//				catch (IOException e)
//				{
//				}
//			}
//		public class UnorderedList
//		{
//			static Node start;
//			Utility u1 = new Utility();
//			ListUtility lu = new ListUtility();

//			public UnorderedList()
//			{
//				try
//				{
//					start = lu.readFile(start);
//					System.out.print("Enter the word to search :");
//					String word1 = u1.inputString();
//					//Search the word
//					start = lu.searchData(start, word1);
//					String word2 = " ";

//					while (start != null)
//					{
//						word2 = word2 + start.data;
//						word2 = word2 + " ";
//						start = start.nextNode;
//					}
//					//  u1.writeToFile(start);
//					lu.writeDataToFile(word2);
//				}
//				catch (NullPointerException n)
//				{
//					System.out.println(n);
//				}
//			}       //End of method

//			public static void main(String[] args)
//			{
//				UnorderedList ul = new UnorderedList();
//			}
//		}
//	}
//	}

