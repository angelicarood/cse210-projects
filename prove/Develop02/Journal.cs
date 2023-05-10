public class Journal
{
  public List<Entry> entryList = new List<Entry>();

  public Journal()
  {
    entryList = new List<Entry>();
  }
  public void AddEntry(string question, string response)
  {
    Entry entry = new Entry(question, response);
    entryList.Add(entry);
  }
  public void DisplayEntries()
  {
    if (entryList.Count == 0)
    {
      Console.WriteLine("Your journal is currently empty. Lets write something interesting!");
    }
    else
    {
      foreach (Entry entry in entryList)
      {
        entry.PrintEntry();
      }

    }
  }
}