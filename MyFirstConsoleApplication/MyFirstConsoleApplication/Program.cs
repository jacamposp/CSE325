using System;
class MyConsoleApplication
{
    static void Main()
    {
        double width, height, woodLength, glassArea;
        string widthString, heightString;
        var name = "Joel";
        var location = "Costa Rica";

        Console.WriteLine($"My name is {name}, I am from {location}");

        string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
        Console.WriteLine("The current date is {0}", date);

        DateTime Xmas = new DateTime(DateTime.Now.Year, 12, 25);
        TimeSpan diff = (Xmas - DateTime.Now);
        Console.WriteLine(diff.Days + " Days till Christmas.");

        Console.WriteLine("Enter the width:");
        widthString = Console.ReadLine();
        width = double.Parse(widthString);
        Console.WriteLine("Enter the height:");
        heightString = Console.ReadLine();
        height = double.Parse(heightString);
        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height);
        Console.WriteLine("The length of the wood is " +
        woodLength + " feet");
        Console.WriteLine("The area of the glass is " +
        glassArea + " square metres");

        Console.Write($"{Environment.NewLine}Press any key to exit...");
        Console.ReadKey(true);
    }
}