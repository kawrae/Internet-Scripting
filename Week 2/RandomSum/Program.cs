// See https://aka.ms/new-console-template for more information
Console.WriteLine("Random Sum");

Random rnd = new Random();

int num1 = rnd.Next(1, 21);
int num2 = rnd.Next(1, 21);
int correctAnswer = num1 + num2;

Console.WriteLine($"What is {num1} + {num2}");

int userAnswer = -1;

while (userAnswer != correctAnswer)
{
    Console.Write("Enter your answer: ");
    userAnswer = int.Parse(Console.ReadLine());

    if (userAnswer == correctAnswer)
    {
        Console.WriteLine("Correct answer.");
    }
    else
    {
        Console.WriteLine("Incorrect try again.");
    }
}

Console.Write("Press any key to exit...");
Console.ReadKey();
