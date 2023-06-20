

Console.WriteLine("This program will allow you to enter a list of students, and then it will display them on the screen.");
Console.WriteLine("This application was built by Juan Jose Figueroa");
Console.WriteLine("-------------------------------------");
Console.WriteLine();

List<string> listStudents = new() { };
bool moreStudents = true;

while (moreStudents)
{
    Console.Write($"Enter the name of student No.{listStudents.Count + 1} : ");
    string? nameStudent = Console.ReadLine();
    if (nameStudent != null)
    {
        listStudents.Add(nameStudent);
    }

    Console.Write("Do you want to add another student? y/n: ");
    string anotherStudent = Console.ReadLine();
    if (anotherStudent.ToLower() == "n")
    {
        moreStudents = false;
    }
}

int numberStudent = 0;
Console.WriteLine("List of all entered students: ");
foreach (string student in listStudents)
{
    Console.WriteLine($"Name of the {++numberStudent}.{student}");
}
Console.WriteLine("---------------------------------------");
Console.WriteLine();
Console.WriteLine("Thank you for using this program, greetings");
Console.ReadLine();