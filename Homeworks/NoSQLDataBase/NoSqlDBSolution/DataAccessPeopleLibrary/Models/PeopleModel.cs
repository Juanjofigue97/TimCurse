using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessPeopleLibrary.Models
{
    public class PeopleModel
    {
        [BsonId]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NameCompany { get; set; }
        public string Description { get; set; }
        public int NumberOfBranches { get; set; }
        public List<AddressModel> AddressList { get; set; } = new List<AddressModel>();
        public List<EmployerModel> Employers { get; set; } = new List<EmployerModel>();


    }
}
