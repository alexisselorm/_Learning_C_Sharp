// See https://aka.ms/new-console-template for more information
string str = "The quick brown fox jumps over the lazy dog.";

string[] stri = {"dog","iron"};
Console.WriteLine(str[14]);

Console.WriteLine(str.Length);

foreach (char c in str){
    Console.Write(c);
    if(c == 'n'){
        Console.WriteLine();
        break;
    }
}

// Concat
string outstr;
outstr = String.Concat(stri);
Console.WriteLine(outstr);

// Join
outstr = String.Join(" ",stri);
Console.WriteLine(outstr);

// Compare
int result = String.Compare("grr",str);
Console.WriteLine(result);

// Equals
bool isEqual = String.Equals(str,stri);
Console.WriteLine(isEqual);

// String Searching
// Replace
outstr = str.Replace("fox","gag");
Console.WriteLine(outstr);

// Index
Console.WriteLine(str.IndexOf("fox"));

// Last Index
Console.WriteLine(str.LastIndexOf("o"));

