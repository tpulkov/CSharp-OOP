namespace Shapes
{
    using System;

    public class StartupTest
    {
        public static void Run()
        {
            Shape[] differentShapes =
            {
                new Rectangle(5.5, 3.5),
                new Rectangle(4.2, 7.1),
                new Triangle(6.7, 2.7),
                new Triangle(4, 9),
                new Square(5.25)
            };

            foreach (var shape in differentShapes)
            {
                Console.WriteLine("{0} Area  ->  {1:F2}", shape.GetType().Name, shape.CalculateSurface());
            }
            Console.WriteLine();
        }
    }
}
