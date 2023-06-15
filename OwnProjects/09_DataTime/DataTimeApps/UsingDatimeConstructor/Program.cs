using System.Globalization;

DateTime localDate = DateTime.Now;
DateTime utcDate = DateTime.UtcNow;
List<string> cultureNames = new()
            {
                "en-JM", "en-NZ", "fi-FI","de-CH", "nl-NL"
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
var TimeS = new TimeSpan().Ticks;
Console.WriteLine(TimeS);