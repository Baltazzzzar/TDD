﻿namespace Converter
{
    public class Convert
    {
        public static double ConvertToCm(int inches)
        {
            return inches * 2.54;
        }
        public static double ConvertToM(int inches)
        {
            return inches * 0.0254;
        }
        public static double ConvertToMm(int inches)
        {
            return inches * 25.4;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                int number = int.Parse(args[0]);
                string unit = args[1];
                switch (unit)
                {
                    case "-cm":
                        Console.WriteLine($"The number is: {Convert.ConvertToCm(number)} cm");
                        break;
                    case "-m":
                        Console.WriteLine($"The number is: {Convert.ConvertToM(number)} m");
                        break;
                    case "-mm":
                        Console.WriteLine($"The number is: {Convert.ConvertToMm(number)} mm");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            else if (args.Length == 3)
            {
                if (args[2].Contains("-t"))
                {
                    int number = int.Parse(args[0]);
                    string unit = args[1];
                    switch (unit)
                    {
                        case "-cm":
                            Testing.Test(Convert.ConvertToCm(number), 2.54 * number, "Test for ConvertToCm");
                            break;
                        case "-m":
                            Testing.Test(Convert.ConvertToM(number), 0.0254 * number, "Test for ConvertToM");
                            break;
                        case "-mm":
                            Testing.Test(Convert.ConvertToMm(number), 25.4 * number, "Test for ConvertToMm");
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
public class Testing
{
    public static void Test<T>(T expected, T actual, string description = "Test")
    {
        if (expected.Equals(actual))
        {
            Console.WriteLine($"{description} ++PASSED++. Expected: {expected}, Actual: {actual}");
        }
        else
        {
            Console.WriteLine($"{description} --FAILED--. Expected: {expected}, Actual: {actual}");
        }
    }
}
