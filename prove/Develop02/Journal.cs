using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
  private List<Entry> _entries = new List<Entry>();

  public void AddEntry(string prompt, string response)
  {
    Entry entry = new Entry(prompt, response);
    _entries.Add(entry);
  }

  public void DisplayEntries()
  {
    foreach (Entry entry in _entries)
    {
      Console.WriteLine(entry);
    }
  }

  public int EntriesCount()
  {   
      return _entries.Count;
  }

  public void SaveToFile(string fileName)
  {
    using (StreamWriter writer = new StreamWriter(fileName))
    {
      foreach (Entry entry in _entries)
      {
        writer.WriteLine($"Date: {entry._date}");
        writer.WriteLine($"Prompt: {entry._prompt}");
        writer.WriteLine($"Response: {entry._response}\n");
      }
    }
  }

  public void LoadFromFile(string fileName)
  {
    _entries.Clear();

    try
    {
      using (StreamReader reader = new StreamReader(fileName))
      {
        string line;
        string currentPrompt = null;
        string currentResponse = null;
        DateTime currentDate = DateTime.MinValue;

        while ((line = reader.ReadLine()) != null)
        {
          if (line.StartsWith("Date: "))
          {
            currentDate = DateTime.Parse(line.Substring("Date: ".Length));
          }
          else if (line.StartsWith("Prompt: "))
          {
            currentPrompt = line.Substring("Prompt: ".Length);
          }
          else if (line.StartsWith("Response: "))
          {
            currentResponse = line.Substring("Response: ".Length);
            _entries.Add(new Entry(currentPrompt, currentResponse)
            {
              _date = currentDate,
              _prompt = currentPrompt,
              _response = currentResponse
            });
          }
        }
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"An error occurred while loading the journal: {ex.Message}");
    }
  }
}