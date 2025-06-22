using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToSaveString());
            }
        }
        Console.WriteLine("Your journal has been saved.");
    }

    public void LoadFromFile(string filename)
    {

        if (File.Exists(filename))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                Entry entry = Entry.FromSavedString(line);
                _entries.Add(entry);
            }
            Console.WriteLine("Your journal was loaded");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
