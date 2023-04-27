// See https://aka.ms/new-console-template for more information
Console.WriteLine("-----Display number of days in the month-----");

int m;

Console.WriteLine("Enter month number between 1 to 12: ");
m = Convert.ToInt32(Console.ReadLine());

switch (m)
{
    case 1:
        Console.WriteLine("January has 31 days");
        break;
    case 2:
        Console.WriteLine("February has 28 or 29 days");
        break;
    case 3:
        Console.WriteLine("March has 31 days");
        break;
    case 4:
        Console.WriteLine("April has 30 days");
        break;
    case 5:
        Console.WriteLine("May has 31 days");
        break;
    case 6:
        Console.WriteLine("June has 30 days");
        break;
    case 7:
        Console.WriteLine("July has 31 days");
        break;
    case 8:
        Console.WriteLine("August has 31 days");
        break;
    case 9:
        Console.WriteLine("September has 30 days");
        break;
    case 10:
        Console.WriteLine("October has 31 days");
        break;
    case 11:
        Console.WriteLine("November has 30 days");
        break;
    case 12:
        Console.WriteLine("December has 31 days");
        break;
    default:
        Console.WriteLine("Invalid input!!! enter month number between 1-12");
        break;
}