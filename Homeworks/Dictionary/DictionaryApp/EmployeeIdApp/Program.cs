


Console.WriteLine("In this program, you will enter the employee ID, and I will provide you with the employee's name.");
Console.WriteLine("This program was built by Juan Jose Figueroa");
Console.WriteLine("---------------------------------------------");
Console.WriteLine();

Dictionary<int,string> Employees = new() 
{
    {1 , "Juan Jose Figueroa"},
    {2 , "Marcela Arevalo"},
    {3 , "Monica Lenz"},
};

bool isValid = false;
int idEmployee = 0;
while (!isValid)
{
    Console.Write("Please enter the employee ID: ");
    isValid = int.TryParse(Console.ReadLine(), out idEmployee);
    
    if (!isValid)
    {
        Console.WriteLine("---------------------------");
        Console.WriteLine("Please enter a valid ID.");
        continue;
    }

    var isInDictionary = Employees.Keys.ToList().Find(id => id == idEmployee);

    if (isInDictionary == 0)
    {
        Console.WriteLine($"There is no employee with that ID : {idEmployee}");
        isValid = false;
    }

}

Console.WriteLine("The employee's name is {0}",Employees[idEmployee]);
Console.WriteLine();
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("Thank you for using my program. See you next time!");
Console.ReadLine();