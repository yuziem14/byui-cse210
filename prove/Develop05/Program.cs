using System;
using System.Collections;

class Program
{
    private static int QUIT_OPTION = 4;

    static void Main(string[] args)
    {
        int option = 0;

        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.SetName("Breathing Activity");
        breathingActivity.SetDescription("Help you to relax using the miracle of breathing.");

        ReflectingActivity reflectingActivity = new ReflectingActivity();
        reflectingActivity.SetName("Reflecting Activity");
        reflectingActivity.SetDescription("Help you to reflect about important things.");
        reflectingActivity.SetPrompts(new List<string> {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        });
        reflectingActivity.SetQuestions(new List<string> {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        });

        ListingActivity listingActivity = new ListingActivity();
        listingActivity.SetName("Listing Activity");
        listingActivity.SetDescription("Help you to take notes about your situations.");
        listingActivity.SetPrompts(new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        });

        do {
            Console.WriteLine("Welcome! Choose on of our activities");

            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("> ");
            option = int.Parse(Console.ReadLine());

            if(option == QUIT_OPTION) {
                continue;
            }
            
            if(option == 1) {
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
            }

            if(option == 2) {
                reflectingActivity.DisplayStartingMessage();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
            }

            if(option == 3) {
                listingActivity.DisplayStartingMessage();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
            }

            Console.Clear();
        } while(option != QUIT_OPTION);
    }
}