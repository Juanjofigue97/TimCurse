var users = new Dictionary<string, int>()
{
    { "Lucy", 29 },
    { "Jane", 38 },
    { "John", 41 },
    { "Andrew", 24 }
};

var sortedUsersByValue = users.OrderBy(user => user.Value);

foreach (var user in sortedUsersByValue)
{
    Console.WriteLine($"{user.Key} is {user.Value} years old");
}

var sortedUsersByKey = users.OrderBy(user => user.Key);

foreach (var user in sortedUsersByKey)
{
    Console.WriteLine($"{user.Key} is {user.Value} years old");
}
