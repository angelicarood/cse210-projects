public class Journal
{
  public List<Entry> EntryList = new List<Entry>();

  public Journal()
  {
    EntryList = new List<Entry>();
  }
  public void AddEntry(string question, string response, DateTime date)
  {
    Entry entry = new Entry(question, response, date);
    EntryList.Add(entry);
  }
  public void DisplayEntries()
  {
    if (EntryList.Count == 0)
    {
      Console.WriteLine("Your journal is currently empty. Lets write something interesting!");
    }
    else
    {
      foreach (Entry entry in EntryList)
      {
        entry.PrintEntry();
      }

    }
  }
  public void SaveToFile()
  {
    string fileName = "Entries.txt";
    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
      foreach (Entry entry in EntryList)
      {
        outputFile.WriteLine($"{entry.GetQuestion()},{entry.GetResponse()},{entry.GetDate()}");
      }
    }
  }

}
