// See https://aka.ms/new-console-template for more information
Console.WriteLine("----- Calculator -----");

double n1;
double n2;
int op;

Console.Write("Please enter the first number: ");
n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter the second number: ");
n2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("1. Addition.");
Console.WriteLine("2. Subtraction.");
Console.WriteLine("3. Multiplication.");
Console.WriteLine("4. Division.");

Console.Write("Please select an option : ");
op = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
switch (op)
{

    case 1:
        Console.WriteLine("Addition is : " + Convert.ToInt32(n1 + n2));
        break;

    case 2:
        Console.WriteLine("Subtraction is : " + Convert.ToInt32(n1 - n2));
        break;

    case 3:
        Console.WriteLine("Multiplication  is : " + (n1 * n2));
        break;

    case 4:
        Console.WriteLine("Division is : " + (n1 / n2));
        break;

    default:
        Console.Write("Invalid selection.");
        break;
}
