// See https://aka.ms/new-console-template for more information
using CosmosDBUI;
using DataAccessLibrary.Models;

Console.WriteLine("Hello, World!");

ContactModel user = new()
{
    FirstName = "Tim",
    LastName = "Corey"
};

user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "tim@iam.com" });
user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "you@iam.com" });
user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-3485" });
user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "444-8787" });

Helper.CreateContact(user);
//Helper.GetAllContacs();
//Helper.GetContactById("6debb71f-62f1-4c7d-b0b0-84bddf7f5e5e");
//Helper.RemovePhoneNumberFromUser("555-3485", "6debb71f-62f1-4c7d-b0b0-84bddf7f5e5e");
//Helper.GetAllContacs();

//Helper.RemoveUser("6debb71f-62f1-4c7d-b0b0-84bddf7f5e5e");


Console.WriteLine("Done Processing CosmoDB");
Console.ReadLine();