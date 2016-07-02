namespace DefiningClasses_Part1
{
    using System;
    using GSMTest;

    class Startup
    {
        static void Main(string[] args)
        {
            PhoneTest mpt = new PhoneTest();
            
            Console.WriteLine("PHONE GENERATION: ");
            Console.WriteLine(mpt.TestPhoneCreation());
            Console.WriteLine("PHONE OPERATIONS: ");
            Console.WriteLine(mpt.TestCalls());
        }
    }
}
