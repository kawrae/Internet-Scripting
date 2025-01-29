// See https://aka.ms/new-console-template for more information
Console.WriteLine("Custom Greeting");

DateTime now = DateTime.Now;
Console.WriteLine($"Current Date and Time: {now}");

Int32 hour = now.Hour;

if (hour >= 5 & hour < 12)
{
    Console.Write("Good Morning");
}
else if (hour >= 12 & hour < 18)
{
    Console.Write("Good Afternoon");
}
else if (hour >= 18 & hour < 22)
{
    Console.Write("Good Evening");
}
else
{
    Console.Write("Good Night");
}

Console.Write("\nPress any key to exit...");
Console.ReadKey();
