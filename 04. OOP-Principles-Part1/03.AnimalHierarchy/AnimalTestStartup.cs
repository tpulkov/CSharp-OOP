namespace AnimalHierarchy
{
    using System;

    public class AnimalTestStartup
    {
        public static void Main()
        {
            Animal[] animals =
            {
                new Dog("Balkan", Gender.Male, 4),
                new Dog("Vikyr", Gender.Male, 3),
                new Dog("Pirin", Gender.Female, 7),
                new Dog("Fluf", Gender.Female, 5),

                new Frog("Froggie", Gender.Male, 10),
                new Frog("Kurmitka", Gender.Female, 1),
                new Frog("Hemi", Gender.Male, 3),

                new Cat("Kitty", Gender.Male, 9),
                new TomCat("Tommy", 5),
                new Kitten("Siri",  2)
            };
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Animal Heirarchy Test");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Animal.AverageAge(animals));
            Console.WriteLine();

            foreach (var animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}
