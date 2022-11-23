// See https://aka.ms/new-console-template for more information
string inputStr = "";
// while (inputStr != "exit")
// {
//     inputStr = Console.ReadLine();
//     Console.WriteLine("You entered {0}",inputStr);

// }

// Do-while... Guaranteed to run at least once
do
{
    inputStr = Console.ReadLine();
    Console.WriteLine("You entered {0}", inputStr);
} while (inputStr != "exit");