namespace Student
{
    using System;

    public class StudentLibraryStartupTest
    {
        public static void Run()
        {
            var firstStudent = new Student("Kal", "Jor", "El", "111-22-6969", "Unknown address", "0897654312",
                "kralc-tnek@gmail.com", 4, Universities.MedicalUniversity, Faculties.DentalMedicineFaculty, Speciality.DentalMedicine);


            var secondStudent = new Student("Clark", "Jonathan", "Kent", "988-33-4321", "Unknown address", "0887654321",
                "clark-kent@gmail.com", 4, Universities.SofiaUniversity, Faculties.FMI, Speciality.SoftwareEngineer);

            var thirdStudent = new Student("Lois", "Ellen ", "Lane", "555-69-9876", "Unknown address", "0896969696",
                "lois.lane@gmail.com", 4, Universities.TechnicalUniversity, Faculties.TransportFaculty, Speciality.TransportEngineer);

            bool compareFirstAndSecond = firstStudent.Equals(secondStudent);
            bool compareFirstAndThird = firstStudent.Equals(thirdStudent);
            bool operatorsCompareFirstAndSecond = firstStudent == secondStudent;
            bool operatorsCompareFirstAndThird = firstStudent != thirdStudent;
            var hashCodeTest = firstStudent.GetHashCode();

            // test ToString();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Problem 1. Student class:\n");
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine(firstStudent + "\n");
            Console.WriteLine(secondStudent + "\n");
            Console.WriteLine(thirdStudent + "\n");

            var cloned = thirdStudent.Clone() as Student;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Problem 2. ICloneable:\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Cloned == thirdStudent? {0}", cloned == thirdStudent);
            thirdStudent = secondStudent;
            Console.WriteLine("Cloned == thirdStudent? after swapping? {0}\n", cloned == thirdStudent);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Problem 3. IComparable :\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Compare first and second with Equals: {0}", compareFirstAndSecond);
            Console.WriteLine("Compare first and third with Equals: {0}\n", compareFirstAndThird);

            Console.WriteLine("Compare first and second with == {0}", operatorsCompareFirstAndSecond);
            Console.WriteLine("Compare first and third with == {0}\n", operatorsCompareFirstAndThird);

            Console.WriteLine("Compare first and second with CompareTo: {0}", firstStudent.CompareTo(secondStudent));
            Console.WriteLine("Compare first and third with CompareTo: {0}\n", firstStudent.CompareTo(thirdStudent));

            
        }
    }
}