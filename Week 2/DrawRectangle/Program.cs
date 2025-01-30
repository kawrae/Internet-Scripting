// See https://aka.ms/new-console-template for more information
Console.WriteLine("Draw Rectangle");

Console.WriteLine($"Number of Rows: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine($"Number of columns: ");
int columns = int.Parse(Console.ReadLine());

Console.WriteLine();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.Write("Press any key to exit...");
Console.ReadKey();
