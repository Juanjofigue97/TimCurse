


var workTimeStart = new TimeOnly(8,0);

Console.WriteLine($"The entry to work in the company is {workTimeStart}");

var workTimeEnd = new TimeOnly(18, 0);

Console.WriteLine($"The get out to work in the company is {workTimeEnd}");

Console.WriteLine($"We work {workTimeEnd.Hour - workTimeStart.Hour} hours");

// IsBetween: Is a handy method to quickly understand if a time falls in a range

var sevenAM = new TimeOnly(7, 0);
var elevenAM = new TimeOnly(11, 0);
var onePM = new TimeOnly(13, 0);

Console.WriteLine(elevenAM.IsBetween(sevenAM, onePM)); 