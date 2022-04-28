using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OOPS.StockManagementData
{
    public class StockDataManagement
    {
        public void DisplayStock(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                var stock = JsonConvert.DeserializeObject<List<StockData>>(json);
                Console.WriteLine("Stock Name" + "\t" + "Num Of Shares" + "\t" + "Share Value" + "\t" + "Total Share Value");
                foreach (var data in stock)
                {
                    Console.WriteLine(data.StockName + "\t\t" + data.NumOfShares + "\t\t" + data.ShareValue + "\t\t" + (data.NumOfShares * data.ShareValue));
                }
            }
        }
    }
}
