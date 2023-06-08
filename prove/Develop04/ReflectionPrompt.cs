public class ReflectionPrompt : Prompt
{
    List<string> _reflections = new List<string>();
    List<string> _usedReflections = new List<string>();
    public ReflectionPrompt()
    {
        AddPrompts();
        if (_prompts.Count == 0)
        {
            AddPrompts();
            _usedPrompts.Clear();
        }

        AddQuestions();
        if (_reflections.Count == 0)
        {
            AddPrompts();
            _usedReflections.Clear();
        }
    }
    public void AddPrompts()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
    }
    public void AddQuestions()
    {
        _reflections.Add("Why was this experience meaningful to you?");
        _reflections.Add("Have you ever done anything like this before?");
        _reflections.Add("How did you get started?");
        _reflections.Add("How did you feel when it was complete?");
        _reflections.Add("What made this time different than other times when you were not as successful?");
        _reflections.Add("What is your favorite thing about this experience?");
        _reflections.Add("What could you learn from this experience that applies to other situations?");
        _reflections.Add("What did you learn about yourself through this experience?");
        _reflections.Add("How can you keep this experience in mind in the future?");
    }
}