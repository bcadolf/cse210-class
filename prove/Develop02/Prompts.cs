using System.Diagnostics.Contracts;

public class Prompts
{
    public string _prompt;
    public List<string> _prompts = new List<string>();

    public string PromptGenerator()
    {
        if (_prompts.Count > 0)
        {
            Random rand = new Random();
            int index = rand.Next(_prompts.Count);
            return _prompts[index];


        }
        else
        {
            return "No prompts in the list.";
        }

    }

}