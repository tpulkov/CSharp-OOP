namespace RangeExceptions
{
    using System;

    public class StartupTest
    {
        public static void Run()
        {
            // Test with int
            try
            {
                Console.Write("Please enter Integer number: ");
                int number = int.Parse(Console.ReadLine());

                if (number < 0 || number > 100)
                {
                    throw new InvalidRangeException<int>(1, 100);
                }
            }
            catch (InvalidRangeException<int> exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.WriteLine();

            // Test with DateTime

            var testDate = new DateTime(2016, 4, 19); // change if you want for another test

            var startDate = new DateTime(1980, 1, 1);
            var endDate = new DateTime(2013, 12, 31);

            Console.WriteLine("Test date -> Year: {0} Month: {1} Day: {2}", testDate.Year, testDate.Month, testDate.Day);
            try
            {
                if (testDate < startDate || testDate > endDate)
                {
                    throw new InvalidRangeException<DateTime>(startDate, endDate);

                }
            }
            catch (InvalidRangeException<DateTime> exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
