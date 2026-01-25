using System.Collections.Generic;
using System.IO; 

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

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

    public void SaveToFile(string file)
    {
        // We will write the code to save to a file here next
    }

    public void LoadFromFile(string file)
    {
        // We will write the code to read from a file here next
    }
}