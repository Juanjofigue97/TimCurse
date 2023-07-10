using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicStore.Models
{
    internal class CameraModel : InventoryModel
    {
        public string Resolution { get; set; }
        public int Megapixels { get; set; }
    }
}
