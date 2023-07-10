using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicStore.Models
{
    public class InventoryModel
    {
        public string ProductName { get; set; }
        public int QuantityInStock { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }

    }
}
