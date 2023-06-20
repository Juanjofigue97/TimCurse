using TracksOnTracksOnTracks;


Console.WriteLine(Languages.NewList());
var ListLanguages = Languages.GetExistingLanguages();

foreach (var Language in ListLanguages)
{
    Console.WriteLine(Language);
}

var languages = new List<string>();
languages.Add("C#");
languages.Add("Clojure");
languages.Add("Elm");
languages.Add("C#");

Console.WriteLine(Languages.IsUnique(languages));
