public class Entry
{
  public string Question;
  public string Response;
  public DateTime Date;

  public Entry(string question, string response, DateTime date)
  {
    Question = question;
    Response = response;
    DateTime Date = date;
  }

  public void PrintEntry()
  {
    Console.WriteLine($"{Date}\nQuestion:{Question}\nResponse:{Response}\n");
  }
  public string GetResponse()
  {
    return Response;
  }
  public string GetQuestion()
  {
    return Question;
  }
  public DateTime GetDate()
  {
    return Date;
  }

}