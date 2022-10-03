// See https://aka.ms/new-console-template for more information
int value = 40;

switch (value)
{
    case 50:
        Console.WriteLine("Value is 50");
        break;

    case 51:
        Console.WriteLine("The value is 51");
        break;

    case 52:
    case 53:
    case 54:
        Console.WriteLine("The value might be 52,53 or 54");
        break;

    default:
    Console.WriteLine("Can't find your value");
    break;

}