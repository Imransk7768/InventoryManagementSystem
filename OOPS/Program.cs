using System;
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
            const string STOCK_DATA_PATH = @"H:\Assignments\InventoryManagementSystem\OOPS\StockManagementData\Stock.json";
            StockDataManagement Stock = new StockDataManagement();
            Console.WriteLine("1. Stock Data \n");
            bool check = true;
            while (check)
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
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