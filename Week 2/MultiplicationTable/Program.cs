// See https://aka.ms/new-console-template for more information
Console.WriteLine("Multiplication Table");

Console.Write("Enter an integer: ");
Int32 x = Int32.Parse(Console.ReadLine());
Console.WriteLine($"x = {x}");
Int32 i = 1;

// while (i <= 10)
// {
//     Console.WriteLine($"{i} * {x} = {i*x}");
//     i++;
// }
do
{
    Console.WriteLine($"{i} * {x} = {i * x}");
    i++;
}
while (i <= 10);


Console.Write("Press any key to exit...");
Console.ReadKey();
