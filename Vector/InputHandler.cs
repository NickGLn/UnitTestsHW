using System;
using System.Collections.Generic;

namespace Vectors
{
    public static class InputHandler
    {
        public static int[] GetVectorCoords(string vectorName)
        {
            string input;
            char[] coordNames = new char[] { 'x', 'y', 'z' };
            int[] coords = new int[3];

            Console.WriteLine($"Provide {vectorName} vector coordinates (x, y, z).");
            Console.WriteLine("Coordinates must be integer values\n.\n.");            
            
            for (var i = 0; i < coordNames.Length; i++)
            {
                Console.WriteLine($"Enter \"{coordNames[i]}\" coordinate value for {vectorName} vector");
                input = Console.ReadLine();
                if (int.TryParse(input, out int coord))
                {
                    coords[i] = coord;
                    continue;
                }
                else
                {
                    Console.WriteLine("Your input is not valid integer. Please try again");
                    i -= 1;
                }
            }

            return coords;
        }

    }
}
