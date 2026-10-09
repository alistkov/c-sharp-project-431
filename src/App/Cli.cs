namespace App;

public class Cli
{
    public static void Greeting()
    {
        Console.WriteLine("Welcome to the Brain Games!");
        Console.Write("May I have your name? ");
        var name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
    }
}
