

bool isValidNumber = false;
int number = default;
do
{
    Console.Write("Write a number: ");
    isValidNumber = int.TryParse(Console.ReadLine(),out number);

} while (!isValidNumber);

int range = 1;
do
{
    Console.WriteLine($"Number is : {range} and cube of the 1 is {range*range*range}");
    range++;
}while (range <= number);
