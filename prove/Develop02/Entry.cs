using System.Text.Json.Serialization;

public class Entry
{
    [JsonInclude] public string _date;
    [JsonInclude] public string _entryContent;
    [JsonInclude] public string _promptSelected;

    public void DisplayEntry()
    {
        Console.WriteLine(_promptSelected);
        Console.WriteLine(_entryContent);
        Console.WriteLine(_date);
    }
}