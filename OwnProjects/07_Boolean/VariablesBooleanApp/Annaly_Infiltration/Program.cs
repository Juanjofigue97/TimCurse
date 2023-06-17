using Annaly_Infiltration;

QuestLogic questLogic = new();
// 1. Check if a fast attack can be made
var knightIsAwake = true;
Console.WriteLine($"1.Check if a fast attack can be made");
Console.WriteLine($"if knightIsAwake {knightIsAwake}");
Console.WriteLine(questLogic.CanFastAttack(knightIsAwake));
knightIsAwake = false;
Console.WriteLine($"if knightIsAwake {knightIsAwake}");
Console.WriteLine(questLogic.CanFastAttack(knightIsAwake));

// 2. Check if the group can be spied upon
Console.WriteLine($"2. Check if the group can be spied upon");
var knightIsAwake2 = false;
var archerIsAwake2 = false;
var prisonerIsAwake2 = false;
Console.WriteLine($"if knightIsAwake {knightIsAwake2}");
Console.WriteLine($"if archerIsAwake {archerIsAwake2}");
Console.WriteLine($"if prisonerIsAwake {prisonerIsAwake2}");
Console.WriteLine(questLogic.CanSpy(knightIsAwake2, archerIsAwake2, prisonerIsAwake2));

knightIsAwake2 = false;
archerIsAwake2 = true;
prisonerIsAwake2 = true;
Console.WriteLine($"if knightIsAwake {knightIsAwake2}");
Console.WriteLine($"if archerIsAwake {archerIsAwake2}");
Console.WriteLine($"if prisonerIsAwake {prisonerIsAwake2}");
Console.WriteLine(questLogic.CanSpy(knightIsAwake2, archerIsAwake2, prisonerIsAwake2));


// 3.Check if the prisoner can be signalled

Console.WriteLine($"3.Check if the prisoner can be signalled");
var archerIsAwake3 = false;
var prisonerIsAwake3 = true;
Console.WriteLine($"if knightIsAwake {archerIsAwake3}");
Console.WriteLine($"if prisonerIsAwake {prisonerIsAwake3}");

Console.WriteLine(questLogic.CanSignalPrisoner(archerIsAwake3, prisonerIsAwake3));

archerIsAwake3 = false;
prisonerIsAwake3 = false;

Console.WriteLine($"if knightIsAwake {archerIsAwake3}");
Console.WriteLine($"if prisonerIsAwake {prisonerIsAwake3}");
Console.WriteLine(questLogic.CanSignalPrisoner(archerIsAwake3, prisonerIsAwake3));

//4. Check if the prisoner can be freed

Console.WriteLine($"4. Check if the prisoner can be freed");
var knightIsAwake4 = false;
var archerIsAwake4 = true;
var prisonerIsAwake4 = false;
var petDogIsPresent4 = false;

Console.WriteLine($"if knightIsAwake {knightIsAwake4}");
Console.WriteLine($"if archerIsAwake {archerIsAwake4}");
Console.WriteLine($"if prisonerIsAwake {prisonerIsAwake4}");
Console.WriteLine($"if petDogIsPresent {petDogIsPresent4}");

Console.WriteLine(questLogic.CanFreePrisoner(knightIsAwake4, archerIsAwake4, prisonerIsAwake4, petDogIsPresent4));

knightIsAwake4 = false;
archerIsAwake4 = true;
prisonerIsAwake4 = true;
petDogIsPresent4 = false;

Console.WriteLine($"if knightIsAwake {knightIsAwake4}");
Console.WriteLine($"if archerIsAwake {archerIsAwake4}");
Console.WriteLine($"if prisonerIsAwake {prisonerIsAwake4}");
Console.WriteLine($"if petDogIsPresent {petDogIsPresent4}");
Console.WriteLine(questLogic.CanFreePrisoner(knightIsAwake4, archerIsAwake4, prisonerIsAwake4, petDogIsPresent4));