﻿using System;
using OOPS.InventoryDataManagenemt_Grains;
using OOPS.InventoryData_Grains;
using OOPS.StockManagementData;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>  Welcome to INVENTORY MANAGEMENT System  <<<<<");
            const string INVENTORY_DATA_PATH = @"H:\Assignments\InventoryManagementSystem\OOPS\InventoryData_Grains\Inventory.json";
            //const string INVENTORY_DATA_PATH = @"H:\Assignments\InventoryManagementSystem\OOPS\InventoryDataManagenemt_Grains\InventoryManage.json";
            const string STOCK_DATA_PATH = @"H:\Assignments\InventoryManagementSystem\OOPS\StockManagementData\Stock.json";
            InventoryManagement InData = new InventoryManagement();
            InventoryManager manager = new InventoryManager();
            InventoryData InvData = new InventoryData();
            StockDataManagement Stock = new StockDataManagement();
            Console.WriteLine("1. Display Data\n2. Add Data\n3. Edit Data \n4. Stock Data \n -in Inventory");
            bool check = true;
            while (check)
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        InData.DisplayInventory(INVENTORY_DATA_PATH);
                        break;
                    case 2:
                       Console.WriteLine("Add InventoryData & InventoryList");
                        string inventory_Name = Console.ReadLine();
                        Console.WriteLine("Enter Inventory Details : ");
                        InventoryData data = new InventoryData();
                        data.ItemName = Console.ReadLine();
                        data.ItemWeight = Convert.ToInt32(Console.ReadLine());
                        data.ItemPricePerKg = Convert.ToInt32(Console.ReadLine());
                        manager.AddInventory(data, inventory_Name, INVENTORY_DATA_PATH);
                        break;
                    case 3:
                        Console.WriteLine("Enter the Inventory List Name & GrainsName : ");
                        string inventoryName = Console.ReadLine();
                        string item = Console.ReadLine();
                        manager.EditInventory(inventoryName, item, INVENTORY_DATA_PATH);
                        InData.DisplayInventory(INVENTORY_DATA_PATH);
                        break;
                    case 4:
                       Stock.DisplayStock(STOCK_DATA_PATH);
                       break;
                    default:
                        Console.WriteLine("Program Ends");
                        check = false;
                        break;
                }
            }
        }
    }
}