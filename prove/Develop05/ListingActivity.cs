public class ListingActivity: Activity {
    private int _count;
    private List<string> _prompts = new List<string>();
    private Random _randomGenerator = new Random();

    public void Run() {
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine();
        List<string> answers = GetListFromUser();
        Console.WriteLine($"You listed {answers.Count()} items!");
        Console.WriteLine("\n");
    }

    public void SetPrompts(List<string> prompts) {
        _prompts = prompts;
    }

    public string GetRandomPrompt() {
        return _prompts.ElementAt(_randomGenerator.Next(0, _prompts.Count()));
    }

    public List<string> GetListFromUser() {
        string text = "";
        List<string> answers = new List<string>();

        DateTime end = DateTime.Now.AddSeconds(GetDuration());
        while(DateTime.Now <= end) {
            Console.Write("> ");
            text = Console.ReadLine();
            answers.Add(text);
        }

        return answers;
    }
}