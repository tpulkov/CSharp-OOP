namespace StartupProject
{

    using Student;
    class Startup
    {
        static void Main(string[] args)
        {
            StudentLibraryStartupTest.Run();

            Person.PersonLibraryStartup.Run();

            Array64Bit.ArrayIn64BitLibraryStartup.Run();
        }
    }
}
