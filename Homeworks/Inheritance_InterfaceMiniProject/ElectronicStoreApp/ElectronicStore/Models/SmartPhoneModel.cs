using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicStore.Models
{
    public class SmartPhoneModel : InventoryModel
    {
        public int RamCapacity { get; set; }
        public int StorageMemory { get; set; }
    }
}
