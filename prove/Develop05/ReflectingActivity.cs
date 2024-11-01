public class ReflectingActivity: Activity {
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private Random _randomGenerator = new Random();

    public void Run() {
        DisplayPromt();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine();
        
        DateTime end = DateTime.Now.AddSeconds(GetDuration());
        while(DateTime.Now <= end) {
            DisplayQuestions();
        }
        Console.Clear();
    }

    public string GetRandomPrompt() {
        return _prompts.ElementAt(_randomGenerator.Next(0, _prompts.Count()));
    }

    public string GetRandomQuestion() {
        return _questions.ElementAt(_randomGenerator.Next(0, _questions.Count()));
    }

    public void SetPrompts(List<string> prompts) {
        _prompts = prompts;
    }

    public void SetQuestions(List<string> questions) {
        _questions = questions;
    }

    public void DisplayPromt() {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
    }

    public void DisplayQuestions() {
        Console.Write($"> {GetRandomQuestion()} ");
        ShowSpinner(5);
    }
}