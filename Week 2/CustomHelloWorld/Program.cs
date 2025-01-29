// See https://aka.ms/new-console-template for more information
Console.WriteLine("Custom Hello World");

Random rnd = new Random();
Int32 rndInt = rnd.Next(0, 4);
Console.WriteLine($"The random integer is: {rndInt}");


String[] languages = { "French", "German", "Italian", "Spanish" };
String language = languages[rndInt];
Console.WriteLine($"Random language is: {language}");

switch (language)
{
    case "French":
        Console.WriteLine("Bonjour, Tout va bien?");
        break;
    case "German":
        Console.WriteLine("Guten Morgen");
        break;
    case "Italian":
        Console.WriteLine("Buongiorno, che cazzo?");
        break;
    case "Spanish":
        Console.WriteLine("Buenos senor, que tal?");
        break;
    default:
        Console.WriteLine("Hola Mundo");
        break;
}

Console.Write("Press any key to exit...");
Console.ReadKey();
