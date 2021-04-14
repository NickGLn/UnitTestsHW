using System;
using System.Collections.Generic;

namespace PolygonPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("This program can evaluate polygon perimeter using points coordinates");
                    Polygon polygon;
                    List<Point> points = InputHandler.GetPointCoords();
                    int pointsCount = points.Count;

                    switch (pointsCount)
                    {
                        case 3:
                            polygon = new Polygon(points[0], points[1], points[2]);
                            break;
                        case 4:
                            polygon = new Polygon(points[0], points[1], points[2], points[3]);
                            break;
                        case 5:
                            polygon = new Polygon(points[0], points[1], points[2], points[3], points[4]);
                            break;
                        default:
                            polygon = null;
                            break;
                    }

                    if (polygon is not null)
                    {
                        Console.WriteLine($"This is {polygon.Name} with perimeter {polygon.Perimeter()}");
                    }
                    

                    Console.ReadLine();
                    Console.Clear();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fatal error: {ex.Message}");
            }
        }
    }
}
