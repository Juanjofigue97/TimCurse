


using NeedForSpeed;

int speed = 2;
int batteryDrain = 10;
var car = new RemoteControlCar(speed, batteryDrain);
for (var i = 0; i < 10; i++)
{
    car.Drive();
}
Console.WriteLine(car.BatteryDrained());
