using System;
using System.Xml.Linq;

public class Animal
{
	public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
    public bool Isfed {  get; set; }
    public Animal(string name, string species, int age)
    {
        Name = name;
        Species = species;
        Age = age;
        Isfed = false;
    }
    public void PrintAnimal()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Specie: {Species}");
        Console.WriteLine($"Age: {Age} Years");
        Console.WriteLine($"IsFed: {Isfed}");
    }

}
/*name, species, age, and whether it's fed or not.*/




