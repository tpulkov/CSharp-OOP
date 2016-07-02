namespace Point3D
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PathStorage
    {
        private List<Point> points;

        public PathStorage()
        {
            this.points = new List<Point>();
        }

        public int Count
        {
            get
            {
                return this.points.Count;
            }
        }

        public Point this[int index]
        {
            get
            {
                return this.points[index];
            }
            set
            {
                this.points[index] = value;
            }
        }

        public void AddPoint(Point p)
        {
            this.points.Add(p);
        }

        public void AddPoints(params Point[] p)
        {
            this.points.AddRange(p);
        }

        public void AddPoints(ICollection<Point> p)
        {
            this.points.AddRange(p);
        }

        public override string ToString()
        {
            return String.Join(" -> ", this.points);
        }
    }
}
