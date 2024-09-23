using System;
using System.IO;

public class Journal {
    public List<Entry> _entries = new List<Entry>();

    public Journal() {}

    public void DisplayAll() {
        foreach(Entry entry in _entries) {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void AddEntry(Entry newEntry) {
        _entries.Add(newEntry);
    }

    public void SaveToFile(string file) {
        string filename = file.Replace(".csv", "") + ".csv";
        using(StreamWriter ouputFile = new StreamWriter(filename)) {
            /** Add File Header */
            ouputFile.WriteLine("Date;Prompt;Entry");
            foreach(Entry entry in _entries) {
                ouputFile.WriteLine($"{entry._date};{entry._promptText};{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file) {
        string filename = file.Replace(".csv", "") + ".csv";
        List<string> fileLines = System.IO.File.ReadAllLines(filename).ToList();

        _entries.Clear();
        /** Remove File Header */
        fileLines.RemoveAt(0);

        foreach(string line in fileLines) {
            List<string> data = line.Split(";").ToList();

            DateTime date = DateTime.Parse(data[0]);
            string prompt = data[1];
            string text = data[2];

            Entry entry = new Entry();
            entry._date = date;
            entry._promptText = prompt;
            entry._entryText = text;

            AddEntry(entry);
        }

    }
}