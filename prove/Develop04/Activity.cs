using System;
public class Activity
{
    private string _activityName;
    private int _activityTime;
    private string _message = "Start in...";

    public Activity(string activityName, int activityTime)
    {
        _activityName = activityName;
        _activityTime = activityTime;
    }

    public void GetActivityName()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity. Hope you will enjoy it.\n");
    }

    public int GetActivityTime()
    {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int userSeconds = Int32.Parse(Console.ReadLine());
        _activityTime = userSeconds;
        return userSeconds;
    }

    public void GetReady()
    {
        Console.Clear();
        Spinner spinner = new Spinner();
        spinner.ShowSpinnerReady();
    }

    public void GetDone()
    {
        Spinner spinner = new Spinner();
        spinner.ShowSpinnerDone();
        Console.WriteLine($"\nYou have successfully completed {_activityTime} seconds of the {_activityName} Activity!");
        spinner.ShowSpinner();
    }

    public void CountDown(int time)
    {
        Console.WriteLine();
        for (int i = time; i > 0; i--)
        {
            Console.Write($"{_message}{i}");
            Thread.Sleep(1000);
            string blank = new string('\b', (_message.Length + 5));
            Console.Write(blank);
        }
        Console.Write("\n Enter:");
    }
}
