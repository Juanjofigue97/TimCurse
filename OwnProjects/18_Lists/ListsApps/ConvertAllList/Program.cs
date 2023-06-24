

var words = new List<string>
{
    "falcon",
    "owl",
    "sky",
    "hawk",
    "stork"
};

var upWords = words.ConvertAll(word => word.ToUpper());
var lengthWords = words.ConvertAll(word => word.Length);
var EnglishWords = words.ConvertAll(word => $"English-{word}");

Console.WriteLine(string.Join(',', upWords));
Console.WriteLine(string.Join(',', lengthWords));
Console.WriteLine(string.Join(',', EnglishWords));