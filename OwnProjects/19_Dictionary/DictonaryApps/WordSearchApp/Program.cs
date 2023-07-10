
using WordSearchApp;

var wordsToSearchFor = new[] { "clojure" };
var grid = "jefblpepre\n" +
            "tclojurerm";
var sut = new WordSearch(grid);

foreach (var word in sut.Grid)
{
    Console.WriteLine(word);
}

//var actual = sut.Search(wordsToSearchFor);
//var expected = new Dictionary<string, ((int, int), (int, int))?>
//{
//    ["clojure"] = ((1, 1), (7, 1))
//};