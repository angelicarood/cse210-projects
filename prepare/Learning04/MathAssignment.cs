public class MathAssignment : Assigment
{
  private string _TextBookSection = "";
  private string _Problems = "";
  public MathAssignment() : base()
  {

  }
  public MathAssignment(string studentname, string topic, string textbooksection, string problems) : base(studentname, topic)
  {
    _TextBookSection = textbooksection;
    _Problems = problems;

  }

  public string GetTextBookSec()
  {
    return _TextBookSection;
  }

  public void SetTextBookSec(string textbooksection)
  {
    _TextBookSection = textbooksection;
  }

  public string GetProblems()
  {
    return _Problems;
  }
  public void SetProblems(string problems)
  {
    _Problems = problems;
  }
  public string GetHomeworkList()
  {
    return $"{_StudentName} - {_Topic}\n{_TextBookSection} {_Problems}";
  }
}