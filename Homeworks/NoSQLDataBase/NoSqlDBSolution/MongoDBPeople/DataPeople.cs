using DataAccessPeopleLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessPeopleLibrary.Models.EmployerModel;

namespace MongoDBPeople
{
    public static class DataPeople
    {
        public static List<PeopleModel> GetData()
        {
            List<PeopleModel> output = new();

            PeopleModel people1 = new()
            {
                NameCompany = "Cofinal",
                Description = "Money",
                NumberOfBranches = 3,
                AddressList = new List<AddressModel>()
                {
                    new AddressModel()
                    {
                        Address = "Calle 9",
                        City = "Colombia"
                    },
                    new AddressModel()
                    {
                        Address = "Calle 18",
                        City = "Colombia"
                    }
                },
                Employers = new List<EmployerModel>()
                {
                    new EmployerModel()
                    {
                        FirstName = "Juan",
                        LastName = "Figueroa",
                        Phone = "312-323-4454",
                        ContractType = EmployerModel.Contract.Consultant,
                        DateOfHire = new DateTime(2023,2,10)
                    },
                    new EmployerModel()
                    {
                        FirstName = "Marce",
                        LastName = "Arevalo",
                        Phone = "312-323-3233",
                        ContractType = Contract.Assistant,
                        DateOfHire = new DateTime(2023,2,10)
                    }
                }
            };

            output.Add(people1);

            PeopleModel people2 = new()
            {
                NameCompany = "Bancolombia",
                Description = "Money",
                NumberOfBranches = 2,
                AddressList = new List<AddressModel>()
                {
                    new AddressModel()
                    {
                        Address = "Calle 10",
                        City = "Colombia"
                    },
                    new AddressModel()
                    {
                        Address = "Calle 32",
                        City = "Peru"
                    }
                },
                Employers = new List<EmployerModel>()
                {
                    new EmployerModel()
                    {
                        FirstName = "Carmenza",
                        LastName = "Navarro",
                        Phone = "312-323-4454",
                        ContractType = EmployerModel.Contract.Consultant,
                        DateOfHire = new DateTime(2023,2,10)
                    },
                    new EmployerModel()
                    {
                        FirstName = "Jorge",
                        LastName = "Montenegro",
                        Phone = "312-323-3233",
                        ContractType = EmployerModel.Contract.Consultant,
                        DateOfHire = new DateTime(2021,2,10)
                    }
                }
            };

            output.Add(people2);

            return output;
        }
    }
}
