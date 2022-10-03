// See https://aka.ms/new-console-template for more information
// All functions have a return type

// TODO: Function with a return type
float MilesToKm(float miles)
{
    float result = miles * 1.6f;
    return result;
}

// A function with no return value has a 'void' type
void PrintWithPrefix(string theStr)
{
    Console.WriteLine($"::>{theStr} ");
}

//  Call the first function
Console.WriteLine($"The result is {MilesToKm(8.0f)}");
Console.WriteLine($"The result is {MilesToKm(12.0f)}");

// Call the second function
PrintWithPrefix("Test me baba");
