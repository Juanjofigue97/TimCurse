// See https://aka.ms/new-console-template for more information
using PlayAnalyzerApp;

//Console.WriteLine(PlayAnalyzer.AnalyzeOffField(new Injury(8)));
Console.WriteLine(PlayAnalyzer.AnalyzeOffField(new Foul()));
//Console.WriteLine(PlayAnalyzer.AnalyzeOffField(new Manager("Jürgen Klopp", "Liverpool")));
//Console.WriteLine(PlayAnalyzer.AnalyzeOffField(new Manager("Jürgen Klopp", null)));
//Console.WriteLine(PlayAnalyzer.AnalyzeOffField(4200));

Console.WriteLine(PlayAnalyzer.AnalyzeOffField(new Injury(3)));
Console.WriteLine(PlayAnalyzer.AnalyzeOffField(new Incident()));

Console.ReadLine();