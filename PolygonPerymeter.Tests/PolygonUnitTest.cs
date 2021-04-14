using System;
using Moq;
using Xunit;
using PolygonPerimeter;

namespace PolygonPerymeter.Tests
{
    public class PointTests
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(8, 8);
        Point p3 = new Point(8, 0);

        [Fact]
        public void DistanceToPointTest()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(8, 8);
            Point p3 = new Point(8, 0);

            double distance = p1.DistanceTo(p2);
            Assert.Equal(11.3, distance, precision: 1);
        }

        [Fact]
        public void PolygonNameTest()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(8, 8);
            Point p3 = new Point(8, 0);
            Polygon polygon = new(p1, p2, p3);

            Assert.Equal("Triangle", polygon.Name);
        }
    }
}
