


var nums = new List<int> { 1, 2, 3, 4 };

Console.WriteLine(nums.GetType());

var nums2 = nums.ToArray();
Console.WriteLine(nums2.GetType());

nums.ForEach(num => Console.WriteLine($"{num} * 2: {num*2}"));
nums.ForEach(e => Console.WriteLine(e));

var greatherThanTwo = nums.FindAll(number => number > 2);

greatherThanTwo.ForEach(e => Console.WriteLine(e));
Console.WriteLine(string.Join(',',greatherThanTwo));
