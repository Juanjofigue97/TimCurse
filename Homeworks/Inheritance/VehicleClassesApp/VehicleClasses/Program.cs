

using VehicleClasses;

Console.WriteLine("In this program, we will look at the classes inherited from the Vehicle class.");
Console.WriteLine("This program was created by Juan Jose Figueroa.");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine();

var car = new Car("Prado")
{
    Model = "Toyota",
    Price = 100000,
    NumberOfDoors = 4,
};

var motocycle = new Motorcycle("Staria")
{
    Model = "Hyundai",
    Price = 1200,
    NumberOfWheels = 2,
};

var boot = new Boat("Fishing")
{
    Model = "Revel",
    Price = 50000,
    Lenght = 100,
};


List<Vehicle> vehicles = new()
{
    car,motocycle,boot
};

foreach (var vehicle in vehicles)
{
    vehicle.StartVehicule();

    if (vehicle is Car carProperty)
    {
        Console.WriteLine($"I can access to car Properties: {carProperty.NumberOfDoors }");
    }
}

Console.ReadLine();

