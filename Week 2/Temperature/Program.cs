// See https://aka.ms/new-console-template for more information
Console.WriteLine("Temperature Celsius to Fahrenheit");

Console.WriteLine($"Enter temperature in degrees Centigrade: ");
Double celsius = Double.Parse(Console.ReadLine());

Double fahrenheit = (1.8 * celsius) + 32;

Console.WriteLine($"{celsius}°C is equivelant to {fahrenheit}°F");

Console.Write("Enter any key to exit...");
Console.ReadKey();
