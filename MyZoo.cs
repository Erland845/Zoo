using System;
using System.Threading.Channels;

public class MyZoo
{
    private List<Animal> animals = new List<Animal>();
    public MyZoo()
    {
        animals = new List<Animal>
        {
            new Animal("Leopard", "Big cat", 4),
            new Animal("PeaCock", "Bird", 2) {Isfed =  true},
            new Animal("Gorilla", "Primate", 5) {Isfed = true},
            new Animal("Tiger", "Big cat", 6)
        };
    }
    public void AddAnimal()
    {
        Console.WriteLine("Enter the name of the animal you'd like to add");
        string name = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("What's the species of the animal?");
        string species = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine($"What age is the animal");
        int age;
        while (!int.TryParse( Console.ReadLine(), out age) )
        {
            Console.WriteLine("Invalid input. Please enter a valid number for age.");
        }
        Console.WriteLine();

        Animal newanimal = new Animal(name, species, age);
        animals.Add(newanimal);

    }
    public void FeedAnimal()
    {
        foreach (Animal animal in animals)
        {
            if (!animal.Isfed)
            {
                Console.WriteLine($"Would you like to feed the {animal.Name}?");
                var input = Console.ReadLine().ToLower(); 
                if (input == "yes" || input == "ok")
                {
                    animal.Isfed = true;
                    Console.WriteLine($"{animal.Name} is no longer hungry");
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
                
            }
        }
        Console.WriteLine();
    }
    public void DisplayZoo()
    {
        Console.WriteLine("The zoo contains the following animals:");
        foreach (Animal animal in animals)
        {
            Console.WriteLine();
            animal.PrintAnimal();
        }
    }
   
}
