// See https://aka.ms/new-console-template for more information
Console.WriteLine("Simple Calculator");

Console.WriteLine($"Enter an integer: ");
Int32 x = Int32.Parse(Console.ReadLine());

Console.WriteLine($"Enter a second integer: ");
Int32 y = Int32.Parse(Console.ReadLine());

Console.WriteLine($"x = {x}");
Console.WriteLine($"y = {y}");
Console.WriteLine($"{x} + {y} = {x + y}");
Console.WriteLine($"{x} - {y} = {x - y}");
Console.WriteLine($"{x} x {y} = {x * y}");
Console.WriteLine($"{x} / {y} = {x / y}");
Console.WriteLine($"{x} > {y} = {x > y}");
Console.WriteLine($"{x} >= {y} = {x >= y}");
Console.WriteLine($"{x} == {y} = {x == y}");
Console.WriteLine($"{x} < {y} = {x < y}");
Console.WriteLine($"{x} <= {y} = {x <= y}");
Console.WriteLine($"{x} != {y} = {x != y}");

Console.Write("Press any key to exit...");
Console.ReadKey();
