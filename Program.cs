﻿public class Converter
{
    public double ConvertToCm(int inches)
    {
        return inches * 2.54;
    }
    public double ConvertToM(int inches)
    {
        return ConvertToCm(inches) / 100;
    }
    public double ConvertToMm(int inches)
    {
        return ConvertToCm(inches) * 10;
    }
    void Test(bool criteria, string description)
    {
        if (criteria)
        {
            Console.WriteLine($"SUCCESS, {description}");
        }
        else
        {
            Console.WriteLine($"FAILURE, {description}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Converter converter = new Converter();
        Console.WriteLine(converter.ConvertToCm(1));
        Console.WriteLine(converter.ConvertToM(1));
        Console.WriteLine(converter.ConvertToMm(1));
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