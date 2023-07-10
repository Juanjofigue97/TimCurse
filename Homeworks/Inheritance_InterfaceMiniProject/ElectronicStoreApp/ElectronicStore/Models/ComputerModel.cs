using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicStore.Models
{
    public class ComputerModel : InventoryModel
    {
        public string Processor { get; set; }
        public int Memory { get; set; }
        public int Storage { get; set; }
    }
}
