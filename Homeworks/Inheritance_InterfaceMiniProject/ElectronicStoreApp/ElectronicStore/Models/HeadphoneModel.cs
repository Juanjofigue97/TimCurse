using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicStore.Models
{
    public class HeadphoneModel : InventoryModel
    {
        public string Type { get; set; }
        public bool Wireless { get; set; }
    }
}
