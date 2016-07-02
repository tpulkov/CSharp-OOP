namespace School
{
    using Data;
    using System;
    using System.Collections.Generic;

    public class SchoolTestStartup
    {
        public static void Main()
        {
            //Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Cyan;
            var nakovDisciplines = new List<Disciplines>
            {
                new Disciplines(DisciplineName.Math, 10, 10),
                new Disciplines(DisciplineName.Informatics, 20, 20)
            };

            var kiroDisciplines = new List<Disciplines>
            {
                new Disciplines(DisciplineName.History, 8, 8),
                new Disciplines(DisciplineName.Geography, 6, 6)
            };

            var studentsClassA = new List<Student>
            {
                new Student("Tosho", "Georgiev"),
                new Student("Kiko", "Gogov"),
                new Student("Kosio", "Ivanov")
            };

            var studentsClassB = new List<Student>
            {
                new Student("Toni", "Koeva"),
                new Student("Gergana", "Stoyanova"),
                new Student("Gerry", "Ivanova")
            };

            var teachers = new List<Teacher>
            {
                new Teacher("Svetlin", "Nakov", nakovDisciplines),
                new Teacher("Gosho", "Georgiev", kiroDisciplines)
            };

            var classA = new SchoolClass(teachers, studentsClassA);
            var classB = new SchoolClass(teachers, studentsClassB);

            var school = new School(new List<SchoolClass> { classA, classB });
            Console.WriteLine(school);

        }
    }
}
