﻿namespace Students.Tests
{
    using System;
    using System.Collections.Generic;
    using Extentions;
    using Models;

    public class StudentListTest
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Angel", "Georgiev", 22, "896506", "042 456 321", "a.georgiev@dir.bg", new Group(2, "FMI")));
            students[0].AddMarks(4.0, 6.0);
            students.Add(new Student("Gosho", "Dinev", 23, "789607", "02 456 322", "g.dinev@abv.bg", new Group(2, "Mathematics")));
            students[1].AddMarks(4, 3, 5);
            students.Add(new Student("Ani", "Petrova", 34, "7896106", "0887 456 323", "a.petrova@abv.bg", new Group(2, "FMI")));
            students[2].AddMarks(2, 3, 5);
            students.Add(new Student("Pesho", "Ivanov", 21, "896205", "056 456 324", "p.ivanov@abv.bg", new Group(3, "FMI")));
            students[3].AddMarks(4, 6);
            students.Add(new Student("Dragan", "Georgiev", 32, "654106", "02 456 325", "d.georgiev@adir.bg", new Group(3, "Mathematics")));
            students[4].AddMarks(4, 4, 3, 5, 3);
            students.Add(new Student("Ivan", "Peevski", 33, "964107", "02 456 333", "i.peevski@abv.bg", new Group(2, "FMI")));
            students[5].AddMarks(6);
            students.Add(new Student("Peter", "Dimitrov", 20, "654108", "0887 456 334", "p.dimitrov@abv.bg", new Group(6, "Mathematics")));
            students[6].AddMarks(4, 6, 3, 3, 2);
            students.Add(new Student("Rosen", "Popov", 20, "789109", "0887 456 335", "r.popov@abv.bg", new Group(2, "Mathematics")));
            students[7].AddMarks(3);
            students.Add(new Student("Desi", "Georgieva", 19, "954206", "0887 456 316", "d.georgieva@dir.bg", new Group(4, "Mathematics")));
            students[8].AddMarks(6, 6, 5, 4, 6, 4);
            students.Add(new Student("Maria", "Mileva", 18, "652105", "02 456 356", "m.mileva@abv.bg", new Group(1, "FMI")));
            students[9].AddMarks(6, 6, 6, 6);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("09. Students in group 2 - LINQ query, оrdered by FirstName");
            students.FindStudentsFromGivenGroup(2).Print();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("10. Students in group 2 - LINQ extension methods, оrdered by FirstName");
            students.FindStudentsFromGGivenGroupUsingLambda(2).Print();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("11. Students with emails in abv.bg");
            students.FindSudentsWithSGivenEmailDomain("abv.bg").Print();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("12. Students with phones in Sofia");
            students.FindSudentsWithSGivenphoneAreaCode("02 ").Print();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("13. Students with at least one 6");
            students.FindSudentsWithSGivenMark(6.0).PrintSelected();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("14. Students with exaactlly 2 marks");
            students.FindStudentsWithGivenMarksCount(2).Print();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("15. Marks of students enrolled 2006");
            Console.ForegroundColor = ConsoleColor.Cyan;
            var marks = students.FindStudentsEnrolled2006();
            Console.WriteLine(string.Join("\n", marks));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("16. Students in \"Mamthematics department\"");
            students.FindStudentsFromGivenDepartment("Mathematics").Print();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("18. Grouped by Group number LINQ");
            students.GroupedByGroupNumberLinq().PrintGrouping();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("19. Grouped by Group number Extention Methods");
            students.GroupedByGroupNumberLambda().PrintGrouping();
        }
    }
}
