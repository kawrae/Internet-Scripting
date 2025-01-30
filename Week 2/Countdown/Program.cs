// See https://aka.ms/new-console-template for more information
Console.WriteLine("Real-Time Countdown");

for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
    System.Threading.Thread.Sleep(1000);
}

Console.WriteLine("Boom");

Console.Write("Press any key to exit...");
Console.ReadKey();
