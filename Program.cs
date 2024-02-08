double ConvertToCm(int inches)
{
    return inches * 2.54;
}

double ConvertToM(int inches)
{
    return ConvertToCm(inches) / 100;
}

double ConvertToMm(int inches)
{
    return ConvertToCm(inches) * 10;
}

Test(ConvertToCm(1) == 2.54, "1 inch is 2.54 cm");
Test(ConvertToM(1) == 0.0254, "1 inch is 0.0254 cm");
Test(ConvertToMm(1) == 25.4, "1 inch is 25.4 cm");

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