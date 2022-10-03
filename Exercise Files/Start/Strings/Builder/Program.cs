// See https://aka.ms/new-console-template for more information
using System.Text;

int jumpcount = 10;
string[] animals = { "goat", "cat", "fish" };

StringBuilder sb = new StringBuilder("Initial String.", 200);

// Some Properties of the String Builder 
Console.WriteLine("{0}, {1}", sb.Capacity, sb.Length);

// Add Some strings to the Builder
sb.Append("The quick brown fox ");
sb.Append("jumped over the lazy dog.");

// Add an empty line
sb.AppendLine();

// AppendFormat to append formatted strings
sb.AppendFormat("He did this {0} times.", jumpcount);

// AppendJoin can iterate over a list 
sb.Append("He also jumped over");
sb.AppendJoin(",",animals);

// Replace the content
sb.Replace("fox","hyena");

// Insert some content at any index
sb.Insert(0,"This is the ");

// Convert everything to a single string
Console.WriteLine("{0}, {1}", sb.Capacity, sb.Length);

Console.WriteLine(sb.ToString());