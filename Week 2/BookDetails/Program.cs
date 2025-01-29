using System.Net;

class Program
{
    static void Main()
    {
        Console.WriteLine("Book Details\n------------");

        // String title = "Harry Potter and the Half Blood Prince";
        Console.Write("What is the title? ");
        String title = Console.ReadLine();

        // String author = "J.K Rowling";
        Console.Write("Who is the author? ");
        String author = Console.ReadLine();

        // Int32 pages = 223;
        Console.Write("How many pages? ");
        Int32 pages = Int32.Parse(Console.ReadLine());

        // Double price = 10.50;
        Console.Write("What is the price? ");
        Double price = Double.Parse(Console.ReadLine());

        // DateTime publicationDate = new DateTime(1997, 12, 26);
        Console.Write("What is the publication date? ");
        DateTime publicationDate = DateTime.Parse(Console.ReadLine());
        
        // Boolean inStock = true;
        Console.Write("Is the book in stock? ");
        Boolean inStock = Boolean.Parse(Console.ReadLine());

        Console.WriteLine($"\nTitle: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Pages: {pages}");
        Console.WriteLine($"Price: {price:c2}");
        Console.WriteLine($"Publication Date: {publicationDate:dd MMM yyyy}");
        Console.WriteLine($"In Stock: {inStock}");

        Console.Write("Press any key to exit..");
        Console.ReadKey();
    }
}
