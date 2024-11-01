public class Activity {
    private string _name;   
    private string _description;   
    private int _duration;

    protected int GetDuration() {
        return _duration;
    }
    public void SetName(string name) {
        _name = name;
    }

    public void SetDescription(string description) {
        _description = description;
    }

    public void DisplayStartingMessage() {
        Console.WriteLine($"Welcome to {_name}!");
        Console.WriteLine(_description);
        Console.WriteLine("In seconds, how long your session should be active?");
        Console.Write("> ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Prepare...");
        ShowSpinner(3);
        Thread.Sleep(1000);
        Console.Clear();
    }

    public void DisplayEndingMessage() {
        Console.WriteLine("Congratulations! You Finished!");
        ShowSpinner(3);
        Console.WriteLine($"Hope this {_duration} seconds has changed your life to be a little bit better!");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds) {
        List<string> animationStrings = new List<string>{"|", "\\", "-", "/"};
        DateTime end = DateTime.Now.AddSeconds(seconds);

        while(DateTime.Now < end) {
            animationStrings.ForEach(step => {
                Console.Write(step);
                Thread.Sleep(200);
                Console.Write("\b \b");
            });
        }
        Console.WriteLine("Done.");
    }

    public void ShowCountDown(int seconds) {
        int counter = seconds;

        while(counter != 0) {
            for(int i = 0; i < 5; i++) {
                Console.Write(".");
                Thread.Sleep(100);
            }

            Console.Write($"{counter}");
            counter--;
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        Thread.Sleep(500);
    }
}