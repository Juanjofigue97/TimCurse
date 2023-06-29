


using PropertyApp;

var homeAddress = new Addresses("Pasto", "Calle 9 No.42-20");

homeAddress.Street = "Calle 11";
homeAddress.PostalCode = "12345";
Console.WriteLine($"Full Address: {homeAddress.FullAddress}");