// See https://aka.ms/new-console-template for more information

using OverrringVsOverloading;

var derive = new DerivedClass();

// Method Overriding VS Method Overloading 
// 1. Multiple methos of same name are in different class -- single class
// 2. Inheritance is used, as it is in different class. -- No need of inheritance
// 3. Both methods have same signature -- have different signature
// 4. It's a run time polymorphism -- compile time polymorphism
// 5. Virtual & override keywords. -- No special keyword used

// Is used to modify and provide a new implementation of the method inherited

derive.Greetings();

Console.ReadLine();