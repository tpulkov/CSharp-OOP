namespace Point3D
{
    using System;

    public static class Distance
    {
        public static double Calculate(Point p, Point q)
        {
            return Math.Sqrt(Math.Pow((p.X - q.X), 2) + Math.Pow((p.Y - q.Y), 2) + Math.Pow((p.Z - q.Z), 2));
        }
    }
}
