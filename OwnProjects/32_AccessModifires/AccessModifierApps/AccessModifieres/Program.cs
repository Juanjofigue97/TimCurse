
using AccessModifieres;

var p = new Person();
p.name = "Jane";

p.SetAge(17);

Console.WriteLine($"{p.name} is {p.GetAge()} years old");