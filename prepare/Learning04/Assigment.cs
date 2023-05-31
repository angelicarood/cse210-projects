public class Assigment
{
  protected string _StudentName = "";
  protected string _Topic = "";

  public Assigment()
  {
  }
  public Assigment(string studentname, string topic)
  {
    _StudentName = studentname;
    _Topic = topic;

  }


  public string GetStudentName()
  {
    return _StudentName;
  }

  public void SetStudentName(string studentname)
  {
    _StudentName = studentname;

  }

  public string GetTopic()
  {
    return _Topic;
  }
  public void SetTopic(string topic)
  {
    _Topic = topic;
  }

  public string GetSummary()
  {
    return $"{_StudentName} - {_Topic}";
  }

}