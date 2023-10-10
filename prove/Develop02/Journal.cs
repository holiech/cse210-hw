public class Journal
{
    public List<Entry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void WriteNewEntry(PromptGenerator promptGenerator)
    {
        Entry newEntry = new Entry();

        newEntry.Date = DateTime.Today.ToString("MM/dd/yyyy");
        newEntry.Prompt = promptGenerator.GetPrompt();
        Console.WriteLine($"{newEntry.Prompt}");
        newEntry.Answer = Console.ReadLine();
        Entries.Add(newEntry);

        Console.WriteLine("Entry saved successfully.");
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in Entries)
        {
            Console.WriteLine($"Date: {entry.Date}\nPrompt: {entry.Prompt}\nResponse: {entry.Answer}\n");
        }
    }

    public void SaveJournalToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in Entries)
            {
                outputFile.WriteLine($"Date: {entry.Date} - {entry.Prompt} {entry.Answer}");
            }
        }
        Console.WriteLine($"Journal saved to {filename}.");
    }

    public void LoadJournalFromFile(string filename)
    {
        Entries.Clear(); // Clear existing entries.

        try
        {
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    char[] separators = { ':', '-', '?' };
                    Entry reader = new Entry();
                    string[] parts = line.Split(separators);

                    reader.Date = parts[1].Trim();
                    reader.Prompt = parts[2].Trim() + "?";
                    reader.Answer = parts[3].Trim();

                    Console.WriteLine($"Date: {reader.Date}\nPrompt: {reader.Prompt}\nResponse: {reader.Answer}\n");
                }
            }
            else
            {
                Console.WriteLine($"File not found: {filename}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading the journal: {ex.Message}");
        }
    }
}

