using OOPS.InventoryData_Grains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.InventoryDataManagenemt_Grains
{
    public class InventoryDetails
    {
        public List<InventoryData> RiceList { get; set; }
        public List<InventoryData> PulsesList { get; set; }
        public List<InventoryData> WheatList { get; set; }
    }
}
