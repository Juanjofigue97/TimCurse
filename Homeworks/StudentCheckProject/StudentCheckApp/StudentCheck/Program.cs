

// Requirements:
// - Console application
// - Ask a user for their name and age.
// - If their name is Bob or Sue (Address them as Professors)
// - If the person is Under 21, recommend they wait X years to start this class

//Plans:
// - Introducing what the application is about.
// - Ask and acquire data
// - Validations
// - Show messages

Console.WriteLine("This application will welcome you to the C# course and provide you with some tips");
Console.WriteLine("This program was built by Juan Jose Figueroa");

Console.WriteLine("-----------------------------");
Console.WriteLine();

Console.Write("What is your name?: ");
string? firstName = Console.ReadLine(); 

if (firstName?.ToUpper() == "BOB" || firstName?.ToUpper() == "SUE")
{
    Console.WriteLine($"Welcome to the course, professor {firstName}. We're glad to have you here");
}else if (firstName == "")
{
    Console.WriteLine("Warning: You didn't enter a valid name");
}
else
{
    Console.WriteLine("Welcome to the course, student. We're glad to have you here");
    Console.Write("How old are you? ");
    bool isValiteAge = int.TryParse(Console.ReadLine(), out int ageStudent);
    
    if (isValiteAge && ageStudent>0 && ageStudent<130)
    {
        if(ageStudent>= 21 ) 
        {
            Console.WriteLine("We are ready to start!");
        }
        else
        {
            Console.WriteLine($"We recommend that you wait for {21 - ageStudent} years to start this course.");
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number between 0 and 130 years");
    }
}
Console.WriteLine();
Console.WriteLine("-----------------------------");
Console.WriteLine();
Console.WriteLine("Thank you for using this program. See you soon!");
Console.ReadLine();