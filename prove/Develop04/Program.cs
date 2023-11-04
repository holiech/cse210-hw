using System;
using System.Threading;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program");

        Menu choice = new Menu();

        int action = 0;
        while (action != 5)
        {
            action = choice.GetUserChoice();
            switch (action)
            {
                case 1:
                    StartBreathingActivity();
                    break;
                case 2:
                    StartReflectingActivity();
                    break;
                case 3:
                    StartListingActivity();
                    break;
                case 4:
                    StartGratitudeActivity();
                    break;
                case 5:
                    Console.WriteLine("\nGoodbye. You are welcome to play again next time.");
                    break;
                default:
                    Console.WriteLine($"\nSorry, invalid option. Please try again.");
                    break;
            }
        }
    }

    public static void StartBreathingActivity()
    {
        Console.Clear();
        BreathingActivity breathing = new BreathingActivity("Breathing", 0);
        breathing.GetActivityName();
        breathing.GetActivityDescription();
        int seconds = breathing.GetActivityTime();
        breathing.GetReady();
        breathing.Breathing(seconds);
        breathing.GetDone();
    }

    public static void StartReflectingActivity()
    {
        Console.Clear();
        ReflectingActivity reflecting = new ReflectingActivity("Reflecting", 0);
        reflecting.GetActivityName();
        reflecting.GetActivityDescription();
        int seconds = reflecting.GetActivityTime();
        reflecting.GetReady();
        reflecting.ShowPrompt(seconds);
        reflecting.GetDone();
    }

    public static void StartListingActivity()
    {
        Console.Clear();
        ListingActivity listing = new ListingActivity("Listing", 0);
        listing.GetActivityName();
        listing.GetActivityDescription();
        int seconds = listing.GetActivityTime();
        listing.GetReady();
        listing.ReturnPrompt(seconds);
        listing.GetDone();
    }

    public static void StartGratitudeActivity()
    {
        Console.Clear();
        GratitudeActivity gratitude = new("Gratitude", 0);
        gratitude.GetActivityName();
        gratitude.GetActivityDescription();
        int seconds = gratitude.GetActivityTime();
        gratitude.GetReady();
        gratitude.ListGratitudeItems(seconds);
        gratitude.GetDone();
    }
}