using System;
public class Menu
{
    public string _userInput;
    private int _userChoice = 0;

    public int GetUserChoice()
    {
        Console.Clear();
        Console.WriteLine("Menu Options");
        Console.WriteLine("Please select one of the following options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Start gratitude activity");
        Console.WriteLine("5. Quit");
        Console.Write("Enter an option: ");

        _userInput = Console.ReadLine();
        _userChoice = 0;

        try
        {
            _userChoice = int.Parse(_userInput);
        }
        catch (FormatException)
        {
            _userChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Unexpected error: {exception.Message}");
        }

        return _userChoice;
    }
}