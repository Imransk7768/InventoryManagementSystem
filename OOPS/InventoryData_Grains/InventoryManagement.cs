using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using OOPS.InventoryData_Grains;

namespace OOPS

{
    public class InventoryManagement
    {
        public void DisplayInventory(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            {
                var json = reader.ReadToEnd();
                var inventory = JsonConvert.DeserializeObject<List<InventoryData>>(json);
                Console.WriteLine("Name" + "\t" + "Weight" + "\t" + "PricePerKg" + "\t" + "TotalPrice");
                foreach (var data in inventory)
                {
                    Console.WriteLine(data.ItemName + "\t" + data.ItemWeight + "\t" + data.ItemPricePerKg + "\t\t" + (data.ItemWeight * data.ItemPricePerKg));
                }
            }
        }
    }
}