using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class EmployeeModel : JobPositionModel
    {
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Email { get; set; }
        public decimal Salary { get; set; }
        public string? TypeJob { get; set; }

        private string IdentificationCard = string.Empty;

        public string ICard
        {
            get 
            { 
                return $"****{IdentificationCard[^4..]}"; 
            }
            set { IdentificationCard = value; }
        }

        public void GetICard()
        {
            Console.WriteLine(IdentificationCard);
        }

        public void SetTitle()
        {
            Title = "Manager";
            Description = "Description";
        }

    }
}
