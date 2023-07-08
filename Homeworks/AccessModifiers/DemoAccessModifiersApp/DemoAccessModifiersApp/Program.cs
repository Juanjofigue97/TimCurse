using EmployeeLibrary;


Console.WriteLine("In this program, we will test all the Access Modifiers.");
Console.WriteLine("-----------------------------------------");
Console.WriteLine();    

var employee = new EmployeeModel
{
    ICard = "1233188475"
};

employee.GetICard();

//Error Because Tilte is Protected
//employee.Title = "Boss";


Console.WriteLine(employee.ICard);

Console.ReadLine();