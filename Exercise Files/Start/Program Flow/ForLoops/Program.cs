// See https://aka.ms/new-console-template for more information
int myVal = 15;
int[] nums = new int[] { 3, 4, 5, 15, 6, 8 };
string str = "Below are some general suggestions you may reference if your department requires these materials. Reference the checklist above to determine if these items are required. Additionally, departments may have specific requirements for completing these items. Any department requirements supersede the guidelines below.";

// For loop
for (int i = 0; i < myVal; i++)
{
    Console.WriteLine("i is currently {0}", i);
}

// Foreach-in loop
foreach (int i in nums)
{
    Console.WriteLine("array number is currently {0}", i);
}
// Console.WriteLine(nums);
int counter = 0;
foreach (char c in str)
{
    if (c == 'e')
    {
        counter++;
    }
}
Console.WriteLine("Counted {0} 'e' characters", counter);
