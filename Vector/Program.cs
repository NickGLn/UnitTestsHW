using System;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input;

                Console.WriteLine($"This program can operate vectors in 3-dimension space\n.\n.");
                while (true)
                {
                    int[] v1Coords = InputHandler.GetVectorCoords("first");
                    int[] v2Coords = InputHandler.GetVectorCoords("second");

                    Vector vector1 = new Vector(v1Coords[0], v1Coords[1], v1Coords[2]);
                    Vector vector2 = new Vector(v2Coords[0], v2Coords[1], v2Coords[2]);

                    string v1Length = Math.Round(vector1.Length(), 2).ToString();
                    string v2Length = Math.Round(vector2.Length(), 2).ToString();
                    string dotProduct = Math.Round(vector1.DotProduct(vector2), 2).ToString();
                    string vectorProduct = vector1.VectorProduct(vector2).CoordsText();
                    string vectorCosine = Math.Round(vector1.Cosine(vector2),2).ToString();
                    string vectorSum = vector1.Sum(vector2).CoordsText();
                    string vectorDiff = vector1.Difference(vector2).CoordsText();

                    Console.WriteLine($"First vector length: {v1Length}");
                    Console.WriteLine($"Second vector length: {v2Length}");
                    Console.WriteLine($"Dot product: {dotProduct}");
                    Console.WriteLine($"Vector product: {vectorProduct}");
                    Console.WriteLine($"Cosine: {vectorCosine}");
                    Console.WriteLine($"Sum: {vectorSum}");
                    Console.WriteLine($"Difference: {vectorDiff}");

                    Console.WriteLine("Type \"exit\" to exit program, \"next\" to test another pair of vectors");
                    input = Console.ReadLine();

                    if (input=="exit") { Environment.Exit(0); } else { continue; }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fatal error: {ex.Message}");

            }
        }
    }
}
