namespace DivisibleBySevenAndThree
{
    using System;
    using Extentions;
    using Utilities.Extentions;

    public class DivisableByTowNumbers
    {
        public static void Main()
        {
            var numbers = new long[] { 3456, 42, 865, 33, 67, 84, 49 };

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("06. Divisible by 3 and 7");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Found with Lambda");
            numbers.FindDivisibleUsingLambda(3, 7).PrintCollection();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Found with LINQ");
            numbers.FindDivisibleUsingLinq(3, 7).PrintCollection();
        }
    }
}