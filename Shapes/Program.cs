using System;
using System.Collections.Generic;
using Shapes.InputHandlers;
using Shapes.Figures;
using Shapes.Operators;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Dictionary<string, double> parameters;
                    Shape shape;
                    
                    Console.WriteLine("\n.\n.\nEnter side size of the box to create Box Container." +
                    "\nSize must be a positive integer or double precision value.\n.\n.");

                    double containerHeight = InputHandler.GetContainerHeight();
                    Box container = new Box(containerHeight);

                    Console.WriteLine($"Succesfully created Box Container with height [{containerHeight}] " +
                        $"and volume [{container.Volume}]");

                    while (true)
                    {
                        Console.WriteLine("Type \"put\" to put shape into the Container.");
                        Console.WriteLine("Type \"new\" to create new Container.\n.\n.");

                        string input = Console.ReadLine();

                        if (input == "put")
                        {
                            Console.WriteLine("\n.\n.\nEnter number of shapeyou want to put inside the box. Type \"exit\" to exit");
                            Console.WriteLine("1 - Box\n2 - Cylinder\n3 - Pyramid\n4 - Ball\n.\n.");

                            switch (InputHandler.GetShapeType())
                            {
                                case 1:
                                    parameters = InputHandler.GetShapeParams(keys: new string[] { "height" }, shapeName: "Box");
                                    ShapeLoader.PutIntoContainer(container, new Box(parameters["height"]));
                                    break;
                                case 2:
                                    parameters = InputHandler.GetShapeParams(keys: new string[] { "height", "radius" }, shapeName: "Cylinder");
                                    ShapeLoader.PutIntoContainer(container, new Cylinder(parameters["height"], parameters["radius"]));
                                    break;
                                case 3:
                                    parameters = InputHandler.GetShapeParams(keys: new string[] { "height", "base side" }, shapeName: "Pyramid");
                                    ShapeLoader.PutIntoContainer(container, new Pyramid(parameters["height"], parameters["base side"]));
                                    break;
                                case 4:
                                    parameters = InputHandler.GetShapeParams(keys: new string[] { "radius" }, shapeName: "Ball");
                                    ShapeLoader.PutIntoContainer(container, new Ball(parameters["radius"]));
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if(input == "new")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Unknown command\n.\n.");
                        }
                    }
                    

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fatal error: {ex.Message}");
                }
            }
            
        }
    }
}
