// See https://aka.ms/new-console-template for more information
void PrintWithPrefix(string theStr, string prefix="Good morning"){
    Console.WriteLine($"{prefix}, {theStr}");
}

// TODO: Call the function with default parameters
PrintWithPrefix("Alexis", "Hey");

// TODO: Call the function with named parameters
PrintWithPrefix(prefix:"%",theStr:"a");