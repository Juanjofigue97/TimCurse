


var nums = new List<int> { 6, -2, 1, 5, 4, 3, 2, 9, -1, 7,-2 };

var filter = nums.FindAll(num => num >= 5);
Console.WriteLine(string.Join('-',filter));

// Return the value if Exist
var findNine = nums.Find(num => num == 9);
Console.WriteLine( findNine);

// Return the index of the value if Exist otherwise return -1
var findFive = nums.FindIndex(num => num <= 5 );
Console.WriteLine(findFive);