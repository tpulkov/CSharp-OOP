namespace Person
{
    using System;

    public class PersonLibraryStartup
    {
        public static void Run()
        {
            var firstPerson = new Person("James Hetfield", 55);
            var secondPerson = new Person("Lars Ulrich");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Problem 4. Person class: \n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
            Console.WriteLine();
        }
    }
}
