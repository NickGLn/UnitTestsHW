using System;
using System.Collections.Generic;

namespace PolygonPerimeter
{
    public class Polygon
    {
        public List<Point> Points { get; }

        public string Name { get; }

        //public Polygon (List<Point> PointsCollection)
        //{
        //    foreach (Point point in PointsCollection)
        //    {
        //        Points.Add(point);
        //    }
        //}

        public Polygon (Point point1, Point point2, Point point3)
        {
            Points = new List<Point> { point1, point2, point3};
            Name = "Triangle";

        }

        public Polygon(Point point1, Point point2, Point point3, Point point4)
        {
            Points = new List<Point> { point1, point2, point3, point4 };
            Name = "Quadrangle";
        }

        public Polygon(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            Points = new List<Point> { point1, point2, point3, point4, point5 };
            Name = "Pentagon";
        }

        public double Perimeter()
        {
            int lastPointIndex = this.Points.Count - 1;
            double result=0;

            for (int i = 0; i < Points.Count; i++)
            {
                if (i == lastPointIndex)
                {
                    result += this.Points[i].DistanceTo(this.Points[0]);
                    break;
                }
                result += this.Points[i].DistanceTo(this.Points[i+1]);
            }
            return Math.Round(result, 1);
        }
    }
}
