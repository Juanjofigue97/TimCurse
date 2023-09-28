

using PythagoreanTripletApp;

int targetsum = 90;
var listnumbers = PythagoreanTriplet.TripletsWithSum(targetsum);

foreach (var item in listnumbers)
{
    Console.WriteLine($"{item.a},{item.b},{item.c}");
}

Console.ReadLine();