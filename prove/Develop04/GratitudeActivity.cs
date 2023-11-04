using System.Diagnostics;

public class GratitudeActivity : Activity
{
    private List<string> _gratitudeList = new List<string>();
    private string _description = "This activity will help you focus on the positive aspects of your life. List things you are grateful for during the session.";

    public GratitudeActivity(string activityName, int activityTime) : base(activityName, activityTime)
    {
    }

    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }

    public void ListGratitudeItems(int seconds)
    {
        Console.WriteLine();
        Console.WriteLine("List as many things as you can that you are grateful for during this session.");
        CountDown(8);
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < seconds)
        {
            _gratitudeList.Add(Console.ReadLine());
        }
        timer.Stop();
        Console.WriteLine($"\nYou listed { _gratitudeList.Count } things you are grateful for!");
    }
}