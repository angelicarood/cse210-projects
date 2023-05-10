public class Entry
{
  public string Question;
  public string Response;
  public DateTime Date;

  public Entry(string question, string response)
  {
    Question = question;
    Response = response;
    Date = DateTime.Now;
  }

  public void PrintEntry()
  {
    Console.WriteLine($"{Date}\nQuestion:{Question}\nResponse:{Response}\n");
  }
}