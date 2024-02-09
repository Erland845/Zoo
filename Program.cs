using Zoo;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyZoo ThisZoo = new MyZoo();
            Console.WriteLine("Welcome to the zoo. Here's the animals it keeps: ");
            ThisZoo.DisplayZoo();
            Console.WriteLine();
            bool operating = false;
            Console.WriteLine("Would you like to enter the zoo?");
            var response = Console.ReadLine().ToLower();
            if (response == "yes" || response == "ok ")
            {
                operating = true;
                while (operating)
                {
                    Console.WriteLine("Choose the number corresponding with your choice");
                    Console.WriteLine();
                    Console.WriteLine("1. for adding a new animal");
                    Console.WriteLine("2. for feeding the animals");
                    Console.WriteLine("3. for exiting the zoo");
                    Console.WriteLine();

                    int input;
                    while (!int.TryParse(Console.ReadLine(), out input))
                    {
                        Console.WriteLine("invalid input. Enter a number corresponding with your choice.");
                        Console.WriteLine();
                    }
                    switch (input)
                    {
                        case 1:
                            ThisZoo.AddAnimal();
                            break;
                        case 2:
                            ThisZoo.FeedAnimal();
                            break;
                        case 3:
                            Console.WriteLine("You'll now be exiting the program");
                            return;
                    }
                    Console.WriteLine("Here's an updated version of your zoo:");
                    ThisZoo.DisplayZoo();
                    Console.WriteLine();

                    Console.WriteLine("Would you like to continue in the zoo?");
                    response = Console.ReadLine().ToLower();
                    if (response != "yes" && response != "ok")
                    {
                        operating = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("In regard to your choice, you will not be entering the zoo.");
            }

            
        }
    }
}


/*Create a program to manage a zoo. The zoo should contain different types of animals, 
  each represented by a class with properties such as name, species, age, and whether it's fed or not.
The program should allow zookeepers to add new animals, remove existing animals, feed animals, 
and check their status (fed or hungry). Implement these functionalities using object-oriented principles, 
lists, and boolean conditions.*/