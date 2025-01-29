// See https://aka.ms/new-console-template for more information
Console.WriteLine("Girls Names");

List<String> girlsNames = new List<String>();

// List<String> girlsNames = new List<String>(){"Solange", "Filianore", "Sirrus", "Fia", "Melina"};

girlsNames.Add("Solange");
girlsNames.Add("Filianore");
girlsNames.Add("Sirrus");
girlsNames.Add("Fia");
girlsNames.Add("Melina");

// Console.WriteLine($"{girlsNames[0]}");
// Console.WriteLine($"{girlsNames[1]}");
// Console.WriteLine($"{girlsNames[2]}");
// Console.WriteLine($"{girlsNames[3]}");
// Console.WriteLine($"{girlsNames[4]}");

foreach (String girlsName in girlsNames)
{
    Console.WriteLine($"{girlsName}");
}

Console.Write("Press any key to exit....");
Console.ReadKey();
