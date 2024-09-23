using System;

public class Entry {
    public string _promptText;
    public string _entryText;
    public DateTime _date;

    public Entry() {}

    public void Display() {
        Console.WriteLine($"Date: {_date.ToShortDateString()} — Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}