

using OverrideVsNew;

Base[] objs = { new Base(), new Derived(), new Base() };

Console.WriteLine("-------------------------");
Console.WriteLine("Info/override");

Derived d = new Derived();
d.Info();
((Base)d).Info();

Base b = new Base();
b.Info();

Console.WriteLine("------------");

foreach (Base obj in objs)
{
    obj.Info();
}

Console.WriteLine("-------------------------");
Console.WriteLine("Info2/new");

Derived d2 = new Derived();
d2.Info2();
((Base)d).Info2();

Base b2 = new Base();
b2.Info2();

Console.WriteLine("------------");

foreach (Base obj in objs)
{
    obj.Info2();
}
