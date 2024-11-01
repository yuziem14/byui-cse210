public class BreathingActivity: Activity {
    public void Run() {
        DateTime end = DateTime.Now.AddSeconds(GetDuration());
        while(DateTime.Now <= end) {
            Console.WriteLine("Breath In");
            ShowCountDown(5);
            Console.WriteLine();
            Console.WriteLine("Breath Out");
            ShowCountDown(5);
            Console.WriteLine();
            Thread.Sleep(500);
            Console.Clear();
        }
    }
}