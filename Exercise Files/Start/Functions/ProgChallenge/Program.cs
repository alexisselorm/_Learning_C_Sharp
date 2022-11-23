using System.Text;
// See https://aka.ms/new-console-template for more information
// TODO: Check if a string is a palindrome
// IsPalindrome returns a tuple of two values
(bool, int) IsPalindrome(string theStr)
{
    string teststr;

    teststr = theStr.ToUpper();

    // Use a stringBuilder to strip out all punctuations
    var sb = new StringBuilder();
    foreach (char c in teststr)
    {
        // Add characters to the builder if not punctuation or white space
        if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
        {
            sb.Append(c);
        }
    }
    // Convert the builder to the finished string
    teststr = sb.ToString();

    // Compare characters starting at the beginning and end of string
    int i = 0, j = teststr.Length - 1;

    // If the indexes cross each other , we're done
    while (i <= j)
    {
        if (teststr[i] != teststr[j])
        {
            return (false, 0);
        }
        // Update the counters and try again
        i++;
        j--;
    }
    return (true, theStr.Length);
}


string inputStr = "";
(bool b, int l) result;
Console.WriteLine("Let's begin");
while (inputStr != "exit")
{
    inputStr = Console.ReadLine();
    if (inputStr !="exit")
   {
    result = IsPalindrome(inputStr);
    Console.WriteLine($"Palindrome {result.b},Length{result.l}");
   }
}