// See https://aka.ms/new-console-template for more information
using System.Globalization;


string str1 = "2";
string str2 = "4.00";
string str3 = "3,000";
string str4 = "4000.00";

int targetNum = 0;

try
{
    // Parsing int
    targetNum = int.Parse(str1);
    Console.WriteLine(targetNum);

    // Parsing Floats
    targetNum = int.Parse(str2, NumberStyles.Float);
    Console.WriteLine(targetNum);

    // Parsing Thousands Marker
    targetNum = int.Parse(str3, NumberStyles.AllowThousands);
    Console.WriteLine(targetNum);

    // Parsing Thousands and/or a decimal
    targetNum = int.Parse(str4, NumberStyles.AllowThousands | NumberStyles.Float);
    Console.WriteLine(targetNum);

    // Parsing booleans
    Console.WriteLine($"{bool.Parse("True")}");

    // Parsing Floats
    Console.WriteLine($"{float.Parse("1.234"):F2}");

}
catch
{
    // TODO
    Console.WriteLine("Conversion error");
}

// Use tryparse to avoid writing your own try-catch
int someOutput;
bool succeeded = false;
succeeded = Int32.TryParse(str1, out someOutput);

if (succeeded)
{
    Console.WriteLine($"{someOutput}");
}