namespace Point3D
{
    using System;

    public struct Point
    {
        private static readonly Point startPoint;
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public static Point StartPoint
        {
            get
            {
                return startPoint;
            }
        }

        public Point(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        static Point()
        {
            startPoint = new Point(0, 0, 0);
        }

        public override string ToString()
        {
            return String.Format("{{{0}, {1}, {2}}}", this.X, this.Y, this.Z);
        }
    }
}
