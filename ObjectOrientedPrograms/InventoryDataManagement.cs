using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedProgramming
{
    class InventoryDataManagement
    {
        public class RootObject
        {
            public string name { get; set; }
            public string weight { get; set; }
            public string price { get; set; }
        }

        public static void Inventory()
        {
            try
            {
                string st = File.ReadAllText(@"C:\Users\Neelabh\source\repos\ObjectOrientedProgramming\ObjectOrientedProgramming\ResultBook.json");
                var res = JsonConvert.DeserializeObject<List<RootObject>>(st);
                int count = 1;
                foreach (var f in res)
                {

                    Console.WriteLine("properties of the {0} item", count);
                    Console.WriteLine("name : "+f.name);
                    Console.WriteLine("price : "+f.price);
                    Console.WriteLine("weight : "+f.weight);
                    count++;
                }
            }

            catch(Exception e)
            {
                Console.WriteLine("LOL ...{0}",e);
            }
            Console.Read();
        }
    }
}
