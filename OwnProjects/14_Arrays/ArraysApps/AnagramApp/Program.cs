

using AnagramApp;

var candidates = new[]
        {
            "dog",
            "goody"
        };
var sut = new Anagram("good");


foreach (var word in sut.FindAnagrams(candidates))
{
    Console.WriteLine(word);
}
