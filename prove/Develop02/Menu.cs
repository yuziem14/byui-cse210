using System;

public class Menu {
    enum Choices {
        Write = 1,
        Display = 2,
        Load = 3,
        Save = 4,
        Quit = 5
    };
    
    PromptGenerator promptGenerator = new PromptGenerator();
    Journal _journal = new Journal();
    string _chosedOption = ""; 

    public Menu() {}

    public void Run() {
        DisplayChoices();
        ChooseOption();
        RunOption();
    }

    public void DisplayChoices() {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine($"{(int) Choices.Write}. Write");
        Console.WriteLine($"{(int) Choices.Display}. Display");
        Console.WriteLine($"{(int) Choices.Load}. Load");
        Console.WriteLine($"{(int) Choices.Save}. Save");
        Console.WriteLine($"{(int) Choices.Quit}. Quit");
    }

    public void ChooseOption() {
        Console.Write("What would you like to do? ");
        _chosedOption = Console.ReadLine();
    }

    public void RunOption() {
        switch(_chosedOption) {
            case var value when _chosedOption == ((int) Choices.Write).ToString():
                WriteNewEntry();
                break;
            case var value when _chosedOption == ((int) Choices.Display).ToString():
                DisplayJournal();
                break;
            case var value when _chosedOption == ((int) Choices.Load).ToString() || _chosedOption == ((int) Choices.Save).ToString():
                try {
                    SaveOrLoadFile();
                } catch(Exception e) {
                    Console.WriteLine("File was not found.");
                }
                break;
            case var value when _chosedOption == ((int) Choices.Quit).ToString():
                break;
            default:
                Console.WriteLine("Invalid Choice.");
                break;
        }
    }

    public Entry GetNewEntry(string prompt, string entryText) {
        Entry entry = new Entry();
        entry._promptText = prompt;
        entry._entryText = entryText;
        entry._date = DateTime.Now;

        return entry;
    }

    public void WriteNewEntry() {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string answer = Console.ReadLine();

        _journal.AddEntry(GetNewEntry(prompt, answer));
    }

    public void DisplayJournal() {
        _journal.DisplayAll();
    }

    public void SaveOrLoadFile() {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        if(filename == "") {
            filename = "journal.csv";
        }

        if(_chosedOption == ((int) Choices.Load).ToString()) {
            _journal.LoadFromFile(filename);
            return;
        }

        _journal.SaveToFile(filename);
    }

    public bool IsFinished() {
        return _chosedOption == ((int) Choices.Quit).ToString();
    }
}