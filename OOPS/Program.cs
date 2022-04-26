using System;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>  Welcome to INVENTORY MANAGEMENT System  <<<<<");
            const string INVENTORY_DATA_PATH = @"H:\Assignments\InventoryManagementSystem\OOPS\InventoryData_Grains\Inventory.json";
            InventoryManagement InData = new InventoryManagement();
            Random random = new Random();
            bool check = true;
            while (check)
            {
                Console.WriteLine("1.Display Data");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        InData.DisplayInventory(INVENTORY_DATA_PATH);
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