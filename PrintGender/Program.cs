// See https://aka.ms/new-console-template for more information
Console.WriteLine("----- Print Gender -----");

char gen;

//Reading gender from user
Console.WriteLine("Enter gender (M/F): ");
gen = Convert.ToChar(Console.ReadLine());
gen = char.ToUpper(gen);

if (gen == 'M')
{
    Console.WriteLine("Gender is Male.");
}
else if (gen =='F')
{
    Console.WriteLine("Gender is Female.");
}
else
{
    Console.WriteLine("Invalid input.");
}
