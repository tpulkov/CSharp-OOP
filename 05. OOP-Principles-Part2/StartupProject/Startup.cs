// Initial StartupProject

namespace StartupProject
{
    using System;
    class Startup
    {
        public static void Main()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Problem 1. Shapes: \n");
            Console.ForegroundColor = ConsoleColor.White;
            Shapes.StartupTest.Run();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Problem 2. Bank accounts: \n");
            Console.ForegroundColor = ConsoleColor.White;
            BankAccounts.StartupTest.Run();


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Problem 3. Range Exceptions: \n");
            Console.ForegroundColor = ConsoleColor.White;
            RangeExceptions.StartupTest.Run();

        }
    }
}
