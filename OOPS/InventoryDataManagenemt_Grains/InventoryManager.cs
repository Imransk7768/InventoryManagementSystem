using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OOPS.InventoryData_Grains;
using OOPS.InventoryDataManagenemt_Grains;

namespace OOPS
{ 
    public class InventoryManager
    {
        InventoryData inventory = new InventoryData();
        InventoryManagement invManage = new InventoryManagement();
        InventoryFactory factory = new InventoryFactory(); 
        List<InventoryData> riceList = new List<InventoryData>();
        List<InventoryData> pulsesList = new List<InventoryData>();
        List<InventoryData> wheatList = new List<InventoryData>();
        public void ReadData(string filePath)
        {
            InventoryDetails details = factory.ReadJson(filePath);
            this.riceList = details.RiceList;
            this.pulsesList = details.PulsesList;
            this.wheatList = details.WheatList;
        }
        public void AddInventory(InventoryData data, string inventoryName, string filePath)
        {
            if (inventoryName.Equals("RiceList"))
            {
                riceList.Add(data);
            }
            if (inventoryName.Equals("PulsesLint"))
            {
                wheatList.Add(data);
            }
            if (inventoryName.Equals("WheatList"))
            {
                pulsesList.Add(data);
            }
            SaveInventory(filePath);
        }
        public void SaveInventory(string filePath)
        {
            InventoryDetails details = new InventoryDetails();
            details.RiceList = riceList;
            details.PulsesList = pulsesList;
            details.WheatList = wheatList;
            factory.WriteToJson(filePath, details);
            invManage.DisplayInventory(filePath);
        }
        public void EditInventory(string inventoryName, string item, string filePath)
        {
            ReadData(filePath);
            InventoryData IData = new InventoryData();
            Console.WriteLine("Enter 1.Rice (or) 2.Wheat (or) 3.Pulses to Edit Data : ");

            if (inventoryName.Equals("Rice"))
            {
                foreach (InventoryData data in riceList)
                {
                    if (data.ItemName.Equals(item))
                    {
                        Console.Write("Select 1.Name, 2.Weight, 3.Price  to Edit: ");
                        int check = Convert.ToInt32(Console.ReadLine());
                        switch (check)
                        {
                            case 1:
                                data.ItemName = Console.ReadLine();
                                break;
                            case 2:
                                data.ItemWeight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                data.ItemPricePerKg = Convert.ToInt32(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            if (inventoryName.Equals("Pulses"))
            {
                foreach (InventoryData data in pulsesList)
                {
                    if (data.ItemName.Equals(item))
                    {
                        Console.Write("Enter 1.Name, 2.Weight, 3.Price to Edit: ");
                        int check = Convert.ToInt32(Console.ReadLine());
                        switch (check)
                        {
                            case 1:
                                data.ItemName = Console.ReadLine();
                                break;
                            case 2:
                                data.ItemWeight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                data.ItemPricePerKg = Convert.ToInt32(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            if (inventoryName.Equals("Wheat"))
            {
                foreach (InventoryData data in wheatList)
                {
                    if (data.ItemName.Equals(item))
                    {
                        Console.Write("Enter 1.Name, 2.Weight, 3.Price  to Edit: ");
                        int check = Convert.ToInt32(Console.ReadLine());
                        switch (check)
                        {
                            case 1:
                                data.ItemName = Console.ReadLine();
                                break;
                            case 2:
                                data.ItemWeight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                data.ItemPricePerKg = Convert.ToInt32(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            SaveInventory(filePath);
        }
    }
}
