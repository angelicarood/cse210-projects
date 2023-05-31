public class WritingAssignment : Assigment
{
  private string _Title = "";

  public WritingAssignment() : base()
  {

  }
  public WritingAssignment(string studentname, string topic, string title) : base(studentname, topic)
  {
    _Title = title;

  }
  public string GetTitle()
  {
    return _Title;
  }
  public void SetTitle(string title)
  {
    _Title = title;
  }

  public string GetWritingInformation()
  {
    return $"{_StudentName} - {_Topic} \n{_Title}";
  }
}