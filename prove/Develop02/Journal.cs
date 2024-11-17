using System.Text.Json;

public class Journal
{
    // public string _journalOwner;
    public string _journalTitle;
    public List<Entry> _entries = new List<Entry>();

    public void DisplayJournal()
    {
        // if (_journalTitle == "")
        // {
        //     Console.Write($"This Journal Belongs to {_journalOwner}.");
        // }
        // else
        // {
        //     Console.Write($"Title: {_journalTitle} --- ");
        //     Console.WriteLine($"By: {_journalOwner}");
        // }
        Console.WriteLine("Entries:");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void SaveFile(string file)
    {
        string jsonString = JsonSerializer.Serialize(_entries);
        File.WriteAllText($"{file}.json", jsonString);
        Console.WriteLine($"Your file has been saved to {file}.json");
    }

    public void LoadFile(string file)
    {
        if (File.Exists($"{file}.json"))
        {
            string jsonString = File.ReadAllText($"{file}.json");
            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString, new JsonSerializerOptions
            {
                IncludeFields = true
            });
            Console.WriteLine("Entries loaded.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

}