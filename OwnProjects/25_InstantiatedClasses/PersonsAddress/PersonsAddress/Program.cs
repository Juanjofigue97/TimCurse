

using PersonsAddress;

var people = ProcessPerson.GetPersons();


foreach (var person in people)
{
    ProcessPerson.PrintAllAddresses(person);
    ProcessPerson.SetPostalCode(person);
    ProcessPerson.PrintAllAddresses(person);
}

