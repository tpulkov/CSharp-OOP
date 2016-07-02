namespace Point3D
{
    class Startup
    {
        static void Main()
        {
            Point p = Point.StartPoint;
            Point q = new Point(1, 2, 3);
            System.Console.WriteLine("Distance: {0:F4}", Distance.Calculate(p, q));

            PathStorage path = new PathStorage();
            path.AddPoints(p, q);
            System.Console.WriteLine(path);
            
            StoragePoint.Save(path, "firstPath");
            System.Console.WriteLine(StoragePoint.Load("firstPath"));
            System.Console.WriteLine(StoragePoint.Load("somePath"));
        }
    }
}
