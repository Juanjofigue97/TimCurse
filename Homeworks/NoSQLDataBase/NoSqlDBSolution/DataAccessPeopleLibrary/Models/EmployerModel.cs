using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessPeopleLibrary.Models
{
    public class EmployerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public Contract ContractType { get; set; }
        public DateTime DateOfHire { get; set; }

        public enum Contract
        {
            Manager,
            Supervisor,
            Consultant,
            Assistant,
        }
    }
}
