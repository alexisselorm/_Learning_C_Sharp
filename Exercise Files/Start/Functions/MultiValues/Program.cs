// See https://aka.ms/new-console-template for more information
// TODO: Tuples are grouped values in C#
(int a, int b) tup1 = (5, 10);
var tup2 = ("Some text", 10.5f);

// TODO: Tuple Values in C# are mutable
tup1.b = 20;
tup2.Item1 = "New text";
Console.WriteLine($"{tup1.a},{tup1.b}");
Console.WriteLine($"{tup2.Item1},{tup2.Item2}");

// TODO: Fucntions can work with tuples
(int,int) result = PlusTimes(6,5);
Console.WriteLine($"Sum:{result.Item1},product:{result.Item2}");
//TODO: Functions can return multiple values using Tuples
static (int,int) PlusTimes(int a, int b){
    return (a+b,a*b);
}