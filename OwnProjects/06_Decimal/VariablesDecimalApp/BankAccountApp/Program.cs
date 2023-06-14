


Console.WriteLine("This application is to keep a record of the money you have in a bank.");
Console.WriteLine("This application was made by Juan Jose Figueroa.");
Console.WriteLine("----------------------------------------------------");
Console.WriteLine();

decimal? bankAccount = null;
bool MoneyOperations = true;

Console.Write("Please enter how much money you have in the account:$ ");

bankAccount = Convert.ToDecimal(Console.ReadLine());

//Console.WriteLine(bankAccount.ToString());

while (MoneyOperations)
{
    Console.WriteLine($"The total amount of money you currently have is: {bankAccount}$");
    Console.WriteLine("Do you want to add a transaction to your account? y/n");
    string addTransaction = Console.ReadLine();
    if (addTransaction.ToUpper() == "Y")
    {
    Console.WriteLine("To add money, enter the number without a sign, and to subtract, use the negative sign (-).");
    Console.Write("Amount of money: ");
        bankAccount += Convert.ToDecimal(Console.ReadLine());
    }
    else
    {
        MoneyOperations = false;
    }
}
Console.WriteLine();
Console.WriteLine("--------------------------------------------------");
Console.WriteLine($"Finally, you have a total of:{bankAccount}$ .");
Console.WriteLine("Thank you for using my application! See you soon!");
Console.ReadLine();
