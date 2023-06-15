using System.Globalization;

Console.WriteLine("This application displays the time in local computer and others Conuntries");
Console.WriteLine("This program is built by Juan Jose Figueroa");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();


//https://www.csharp-examples.net/culture-names/
DateTime localDate = DateTime.Now;
DateTime utcDate = DateTime.UtcNow; //Global Date
List<string> cultureNames = new()
            {
                "en-IE", "en-ZA", "fr-CA","de-CH", "ro-RO","es-CO"
            };

foreach (var cultureName in cultureNames)
{
    var culture = new CultureInfo(cultureName);
    Console.WriteLine("{0}:", culture.NativeName);
    Console.WriteLine("   Local date and time: {0}, {1:G}",
                      localDate.ToString(culture), localDate.Kind);
    Console.WriteLine("   UTC date and time: {0}, {1:G}\n",
                      utcDate.ToString(culture), utcDate.Kind);

}