// See https://aka.ms/new-console-template for more information
int x = 10, y=5;
string something = "Something ", here=" here";

Console.WriteLine(x+y);
Console.WriteLine(something + here);
Console.WriteLine(x > y);

// Null-coalescing operators
string isNull = null;

// TODO: The ?? operator uses left operand if not null or right operand if it is null
Console.WriteLine(isNull ?? "Unkown string");

//TODO: The ??= assigns the right operand if the left operand is null.
Console.WriteLine(isNull ??="Put me here modasoka");