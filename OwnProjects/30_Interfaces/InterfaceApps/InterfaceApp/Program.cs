

using InterfaceApp;

PersonModel person = new PersonModel();
AnimalModel animal = new AnimalModel();

List<IRun> runs = new()
{
    person,animal
};

foreach (var run in runs)
{
    Console.WriteLine(run.Name);
    run.Run();
}