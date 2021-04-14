using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonPerimeter
{
    public static class InputHandler
    {
        public static List<Point> GetPointCoords()
        {
            string input;
            List<Point> points = new List<Point>();
            int pointsCounter = 0;

            Console.WriteLine($"\n.\n.\nEnter from 3 to 5 points coordinates - X and Y for each point" +
                $"\nYou can enter positive or negative integer values.\nPress [Enter] after each element\n.\n." +
                $"\nType \"perimeter\" to interrupt input and evaluate perimeter");


            while (pointsCounter <= 5)
            {
                Console.WriteLine("Enter X coordinate value:");
                input = Console.ReadLine();

                if (int.TryParse(input, out int x))
                {
                    while (pointsCounter <= 5)
                    {
                        Console.WriteLine("Enter Y coordinate value:");
                        input = Console.ReadLine();

                        if (int.TryParse(input, out int y))
                        {
                            points.Add(new Point(x, y));
                            pointsCounter += 1;
                            Console.WriteLine($"Point ({x},{y}) added.");
                            break;
                        }
                        else if (input == "perimeter")
                        {
                            if (pointsCounter >= 3)
                            {
                                return points;
                            }
                            else
                            {
                                Console.WriteLine("Minimum points is 3. You entered {pointCounter}.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Not a valid input. Enter X coordinate value:");
                        }
                    }

                }
                else if (input== "perimeter")
                {
                    if (pointsCounter >= 3)
                    {
                        return points;
                    }
                    else
                    {
                        Console.WriteLine($"Minimum points is 3. You entered {pointsCounter}.");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Not a valid input. Enter X coordinate value:");
                }

            }
            return points;
        }

    }
}

﻿
