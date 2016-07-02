namespace StartupApplication
{
    using AnimalHierarchy;
    using StudentsAndWorkers;
    public class Startup
    {
        public static void Main(string[] args)
        {
            StudentWorkerTestStartup.Main();
            AnimalTestStartup.Main();
        }
    }
}
