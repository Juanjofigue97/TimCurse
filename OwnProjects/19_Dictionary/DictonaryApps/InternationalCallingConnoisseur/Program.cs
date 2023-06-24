

using InternationalCallingConnoisseur;

var countryCodes = DialingCodes.AddCountryToExistingDictionary(DialingCodes.GetExistingDictionary(), 263, "Zimbabwe");
var longestCountryName = DialingCodes.FindLongestCountryName(countryCodes);

Console.WriteLine(longestCountryName);