namespace Students.Tests
{
    using System;
    using Extentions;
    using Models;

    public class StudentArrayTest
    {
        public static void Run()
        {
            var students = new Student[]
            {
                new Student("Tosho", "Georgiev", 15),
                new Student("Ivan", "Kolev", 22),
                new Student("Rayna", "Kabaivanska", 25),
                new Student("Ian", "Kilmister", 20),
                new Student("Gregory", "Smith", 23),
                new Student("Pero", "Perov", 29)
            };

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("03. First name is before last name");
            students.FindFirstBeforeLastName().Print();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("04. Students in age range 18 - 24");
            students.FindStudentsInAgeRange().Print();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("05. Sorted decending with Lambda");
            students.SortStudentsUsingLambda().Print();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("05. Sorted decending with LINQ");
            students.SortStudentsUsingLinq().Print();
        }
    }
}
