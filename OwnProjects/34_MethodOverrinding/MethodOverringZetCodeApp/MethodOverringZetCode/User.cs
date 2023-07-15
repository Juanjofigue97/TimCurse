

var u = new User("John Doe", "gardener");
Console.WriteLine(u);


class User
{
    public User(string name, string occupation)
    {
        this.Name = name;
        this.Occupation = occupation;
    }

    public string Name { get; set; }
    public string Occupation { get; set; }

    public override string ToString()
    {
        return $"{this.Name} is a {this.Occupation}";
    }
}