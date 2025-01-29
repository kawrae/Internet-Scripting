// See https://aka.ms/new-console-template for more information
Console.WriteLine("Boys Names");


String[] boysNames = new String[5];
// String[] boysNames = {"Corey", "John", "Joe", "Jim", "James"};
// String[] boysNames = new String[] {"Corey", "John", "Joe", "Jim", "James"};
// String[] boysNames = new String[5] {"Corey", "John", "Joe", "Jim", "James"};

boysNames [0] = "Corey";
boysNames [1] = "John";
boysNames [2] = "Joe";
boysNames [3] = "Jim";
boysNames [4] = "James";

// Console.WriteLine($"{boysNames[0]}");
// Console.WriteLine($"{boysNames[1]}");
// Console.WriteLine($"{boysNames[2]}");
// Console.WriteLine($"{boysNames[3]}");
// Console.WriteLine($"{boysNames[4]}");

foreach (String boysName in boysNames)
{
    Console.WriteLine($"{boysName}");
}

Console.Write("Press any key to exit....");
Console.ReadKey();