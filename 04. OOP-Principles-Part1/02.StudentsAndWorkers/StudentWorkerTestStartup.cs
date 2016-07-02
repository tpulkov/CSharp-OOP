namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentWorkerTestStartup
    {
        public static void Main()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nStudents sorted by grade in ascending order: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            var students = new List<Student>
            {
                new Student("Gosho", "Kisyov", 5.50),
                new Student("Tosho", "Gurov", 4.75),
                new Student("Gergin", "Savov", 5.75),
                new Student("Marto", "Ganev", 4.25),
                new Student("Ivo", "Tochev", 5.10),
                new Student("Ogi", "Ivanov", 6.00),
                new Student("Kosio", "Gorev", 3.80),
                new Student("Radina", "Simova", 5.30),
                new Student("Ilina", "Georgieva", 4.10),
                new Student("Dima", "Todorova", 5.60)
            };

            var orderByGrade = students.OrderBy(x => x.Grade);

            foreach (var student in orderByGrade)
            {
                Console.WriteLine("Name: {0} {1} | Grade: {2:F2}", student.FirstName, student.LastName, student.Grade);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nWorkers sorted by money per hour in descending order: ");
            Console.ForegroundColor = ConsoleColor.Cyan;

            var workers = new List<Worker>
            {
                new Worker("Genadi", "Genadiev", 500, 10),
                new Worker("Bai", "Petko", 400, 12),
                new Worker("Georgi", "Grozdanov", 1200, 8),
                new Worker("Filip", "Stanev", 3000, 12),
                new Worker("Tsveta", "Mladenova", 5000, 8),
                new Worker("Siika", "Kozhuharova", 600, 12),
                new Worker("Koprinka", "Bojurova", 450, 10),
                new Worker("Stefani", "Kostadinova", 900, 12),
                new Worker("Sava", "Piperov", 1600, 4),
                new Worker("Misho", "Todorov", 1000, 10)
            };

            var sortedByMoney = workers.OrderByDescending(x => x.MoneyPerHour());

            foreach (var worker in sortedByMoney)
            {
                Console.WriteLine("Name: {0} {1} | Money per hour: {2:F2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nMerged and sorted by first and last name: ");
            Console.ForegroundColor = ConsoleColor.Cyan;

            var merged = students.Concat<Human>(workers).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var person in merged)
            {
                Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
            }
        }
    }
}
