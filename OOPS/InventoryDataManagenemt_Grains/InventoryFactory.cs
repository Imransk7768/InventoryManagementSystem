using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using OOPS.InventoryData_Grains;

namespace OOPS.InventoryDataManagenemt_Grains
{
    public class InventoryFactory
    {   
        public InventoryDetails ReadJson(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            string json = reader.ReadToEnd();
            var inventory = JsonConvert.DeserializeObject<InventoryDetails>(json);
            return inventory; 
        }
        public void WriteToJson(string filePath, InventoryDetails details)
        {
            var serializeJson = JsonConvert.SerializeObject(details);
            File.WriteAllText(filePath, serializeJson);
        }
    }
   
}
