using System;

class Program
{
  static void Main(string[] args)
  {
    Journal journal = new Journal();
    bool quit = false;

    while (!quit)
    {
      Console.WriteLine("\n**** Welcome to the Journal App Menu ****");
      Console.WriteLine("\nPlease select from one of the following options:");
      Console.WriteLine("\n1. Write a New Journal Entry");
      Console.WriteLine("2. Display Journal Entries");
      Console.WriteLine("3. Save Journal Entries to a File");
      Console.WriteLine("4. Load File");
      Console.WriteLine("5. Quit Journal App");

      Console.Write("\nSelect an option (1-5): ");
      string choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
          string prompt = PromptGenerator.GetRandomPrompt();
          Console.WriteLine($"\nPrompt: {prompt}");
          Console.Write("Enter your response: ");
          string response = Console.ReadLine();
          journal.AddEntry(prompt, response);
          break;


        case "2":
          if (journal.EntriesCount() == 0)
          {   //count added in journal class to ensure user enters a journal entry. 
              //If not and chooses display then user presented with following message.
              Console.WriteLine("\nYour journal is empty. Please add some entries to your journal first.");
          }
          else
          {
              Console.WriteLine("\n **** Journal **** \n");
              journal.DisplayEntries();
          }
          break;


        case "3":
          Console.Write("\nPlease enter a file name to save your journal entries: ");
          string saveFileName = Console.ReadLine();
          journal.SaveToFile(saveFileName);
          Console.WriteLine("\nJournal saved successfully.");
          break;

        case "4":
          Console.Write("\nPlease enter the file name to load your journal: ");
          string loadFileName = Console.ReadLine();
          journal.LoadFromFile(loadFileName);
          Console.WriteLine("\nJournal loaded successfully.");
          break;

        case "5":
          quit = true;
          Console.WriteLine("\n**** Thank you for using the Journal App ****");
          break;

        default:
          Console.WriteLine("\nInvalid choice. Please select a valid option (1-5).");
          break;
      }
    }
  }
}