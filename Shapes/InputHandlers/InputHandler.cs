using System;
using System.Collections.Generic;
using Shapes.Figures;
using System.Text.RegularExpressions;

namespace Shapes.InputHandlers
{
    public static class InputHandler
    {
        public static double GetContainerHeight()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (double.TryParse(input, out double value))
                {
                    if (value > 0)
                    {
                        return value;
                    }
                    else
                    {
                        Console.WriteLine("Value must be greater than zero.");
                    }
                }
                else if (input == "exit")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Your input is not valid. Please try again or type \"exit\" to exit");
                }
            }
        }
        public static int GetShapeType()
        {
            while (true)
            {
                
                string input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                {
                    if (value > 0)
                    {
                        return value;
                    }
                    else
                    {
                        Console.WriteLine("Value must be greater than zero.");
                    }
                    
                }
                else if (input == "exit")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Your input is not valid. Please try again or type \"exit\" to exit");
                }
            }
            
        }
        public static Dictionary<string, double> GetShapeParams(string[] keys, string shapeName="")
        {
            string input;
            Dictionary<string, double> parameters = new Dictionary<string, double>();

            if(shapeName!="")
            {
                Console.WriteLine($"Provide [{string.Join(',', keys)}] for {shapeName}.");
            }
            else
            {
                Console.WriteLine($"Provide [{string.Join(',', keys)}].", string.Join(',', keys));
            }

            Console.WriteLine("Parameters must be double precision or integer values\n.\n.");

            for (var i = 0; i < keys.Length; i++)
            {
                Console.WriteLine($"Enter \"{keys[i]}\" value for {shapeName}");
                input = Console.ReadLine();

                if (double.TryParse(input, out double value))
                {
                    if (value > 0)
                    {
                        parameters[keys[i]] = value;
                    }
                    else
                    {
                        Console.WriteLine("Value must be greater than zero.");
                        i -= 1;
                        continue;
                    }


                }
                else if (input == "exit")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Your input is not valid. Please try again");
                    i -= 1;
                }
            }

            return parameters;
        }
    }

}
