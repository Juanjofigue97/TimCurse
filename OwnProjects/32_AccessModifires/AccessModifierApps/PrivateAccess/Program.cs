

Console.WriteLine("Member fields with private access modifiers are not inherited by derived classes");
var derived = new Derived();
derived.info();

class Base
{
    public string name = "Base";
    protected int id = 5323;
    private bool isDefined = true;
}

class Derived : Base
{
    public void info()
    {
        Console.WriteLine("This is Derived class");
        Console.WriteLine("Members inherited");
        Console.WriteLine(this.name);
        Console.WriteLine(this.id);
        // Console.WriteLine(this.isDefined);
    }
}