namespace StartTest
{
    using System;

    using DivisibleBySevenAndThree;
    using IEnumerable.Tests;
    using InfiniteConvergetSeries;
    using LongestString;
    using StringBuilder.Test;
    using Students.Tests;
    using TimerWithDelegate;
    using TimerWithEvent;

    public class Startup
    {
        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            StringbulderExtentionTest.Main();
            IEnumerableCalculationTest.Main();
            StudentArrayTest.Run();
            DivisableByTowNumbers.Main();
            TimerDelegateTest.Main();
            TimerWithEventTest.Main();
            StudentListTest.Main();
            Test.Main();
            InfiniteConvergetSeries.Main();
        }
    }
}
