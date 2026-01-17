using System;

namespace ResumesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ResumeManager resumeManager = new ResumeManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nResumes Menu");
                Console.WriteLine("1. Create a new resume entry");
                Console.WriteLine("2. Display all resume entries");
                Console.WriteLine("3. Save resumes to a file");
                Console.WriteLine("4. Load resumes from a file");
                Console.WriteLine("5. Quit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        resumeManager.CreateEntry();
                        break;

                    case "2":
                        resumeManager.DisplayEntries();
                        break;

                    case "3":
                        Console.Write("Enter filename to save: ");
                        string saveFile = Console.ReadLine();
                        resumeManager.SaveToFile(saveFile);
                        break;

                    case "4":
                        Console.Write("Enter filename to load: ");
                        string loadFile = Console.ReadLine();
                        resumeManager.LoadFromFile(loadFile);
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}

class ResumeManager
{
    private List<ResumeEntry> _entries = new List<ResumeEntry>();

    public void CreateEntry()
    {
        Console.Write("Enter job title: ");
        string jobTitle = Console.ReadLine();

        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Enter duration (e.g., Jan 2020 - Dec 2021): ");
        string duration = Console.ReadLine();

        ResumeEntry entry = new ResumeEntry(jobTitle, companyName, duration);
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (ResumeEntry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (ResumeEntry entry in _entries)
            {
                writer.WriteLine(entry.ToFileString());
            }
        }

        Console.WriteLine("Resumes saved successfully.");
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts.Length == 3)
            {
                ResumeEntry entry = new ResumeEntry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
            }
        }

        Console.WriteLine("Resumes loaded successfully.");
    }
}

class ResumeEntry
{
    private string _jobTitle;
    private string _companyName;
    private string _duration;

    public ResumeEntry(string jobTitle, string companyName, string duration)
    {
        _jobTitle = jobTitle;
        _companyName = companyName;
        _duration = duration;
    }

    public void Display()
    {
        Console.WriteLine($"\nJob Title: {_jobTitle}");
        Console.WriteLine($"Company: {_companyName}");
        Console.WriteLine($"Duration: {_duration}");
    }

    public string ToFileString()
    {
        return $"{_jobTitle}|{_companyName}|{_duration}";
    }
}