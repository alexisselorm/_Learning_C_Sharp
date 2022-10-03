// See https://aka.ms/new-console-template for more information
string make = "Mercedes-Benz";
string model = "G Class";
int year  = 2020;
float miles = 8_450.27f;
decimal price =60_275.28m;
 

// Interpolation
Console.WriteLine($"This car is a {make} {model} {year}, with {miles} and it costs {price:C2}");

// Inline Expressions
Console.WriteLine($"This car is a {make} {model} {year}, with {miles * 1.6:N2} kilometers and it costs {price:C2}");

// Escaping braces, Use double braces around the braces
Console.WriteLine($"This car is a {make} {model} {year}, with {{{miles * 1.6:N2}}} kilometers and it costs {price:C2}");

