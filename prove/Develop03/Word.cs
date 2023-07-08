public class Word
{
    private string _word;
    private bool _word_status;

    public Word(string word)
    {
        _word = word;
        _word_status = true;
    }
    public string HideWord(){
        if (_word_status == true)
        {
            return _word;
        } else
        {
            _word = "__";
            return _word;
        }
    }
}