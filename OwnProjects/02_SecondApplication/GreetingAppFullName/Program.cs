

// Welcome the user to Application
Console.WriteLine("Welcome to my App , it's a pleasure to have you here");
Console.WriteLine("This application was built by Juan Jose Figueroa.");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine();

// Ask for First Name
Console.Write("What is your first name: ");

string? firstName = Console.ReadLine();

// Ask for Surname Name
Console.Write("What is your lastName: ");
string? lastName = Console.ReadLine();

//Greet user by name
Console.WriteLine("Welcome to my program " + firstName+" "+ lastName);
Console.WriteLine();
Console.WriteLine("Thank you for using this program, greetings");
Console.WriteLine("Good bye!");
Console.WriteLine("--------------------------------------------------");
Console.ReadLine();