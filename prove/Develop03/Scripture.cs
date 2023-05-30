public class Scripture
{
    List<Word> _words = new List<Word>();
    Reference _ref;
    string scriptureString = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
    public Scripture(Reference reference)
    {
        _ref = reference;
    }
    public void ConvertStringtoWord()
    {
        foreach (string word in scriptureString.Split(" "))
        {
            Word w = new Word(word);
            _words.Add(w);
        }
    }
    public void HideRandomWord()
    {
        var random = new Random();
        var randomNumber = random.Next(0,_words.Count);
        var randomWord = _words[randomNumber];

        
    }
    public void Display()
    {
        foreach (Word word in _words)
        {
            Console.Write($"{word.HideWord()} ");
        }
    }
}