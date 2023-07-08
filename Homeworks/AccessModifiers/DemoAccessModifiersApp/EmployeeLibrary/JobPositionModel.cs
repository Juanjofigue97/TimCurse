using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class JobPositionModel
    {
        internal string? Title { get; set; }
        protected string? Description { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }

    }
}
