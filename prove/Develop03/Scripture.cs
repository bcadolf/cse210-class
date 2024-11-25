public class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int num)
    {
        int length = _words.Count;
        Random rand = new Random();

        for (int i = 0; i < num; i++)
        {
            int randIndex;
            do { randIndex = rand.Next(length); } while (_words[randIndex].IsHidden());

            _words[randIndex].Hide();

        }
    }


    public string GetText()
    {
        string scripture = String.Join(" ", _words.Select(word => word.GetText()));
        string reference = _reference.GetText();
        return $"{reference} ~~ {scripture}";
    }
    public bool AllHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}