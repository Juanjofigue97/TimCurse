
using WordSearchApp;

var wordsToSearchFor = new[] { "clojure" };
var grid = "jefblpepre\n" +
            "tclojurerm";
var sut = new WordSearch(grid);


var letters = sut.Grid.Where(x => x.Value == 'e');



var actual = sut.Search(wordsToSearchFor);
var expected = new Dictionary<string, ((int, int), (int, int))?>
{
    ["clojure"] = ((1, 1), (7, 1))
};