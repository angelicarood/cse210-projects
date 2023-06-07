public class Mindfulness
{
  private string _ActivityName;
  private int _Time;
  private string _Description;

  public Mindfulness(string activityname, int time, string description)
  {
    _ActivityName = activityname;
    _Time = time;
    _Description = description;

  }

  public string GetActivityName()
  {
    return _ActivityName;
  }
  public void SetActivityName(string activityname)
  {
    _ActivityName = activityname;

  }
  public int GetTime()
  {
    return _Time;
  }
  public void SetTime(int time)
  {
    _Time = time;

  }
  public string GetDescription()
  {
    return _Description;
  }
  public void SetDescription(string description)
  {
    _ActivityName = description;

  }
  public string GetStartMessage()
  {
    return $"Welcome to the {_ActivityName}\n{_Description}";


  }
  public int GetTimeUser()
  {
    Console.Write("Enter the duration in seconds:");
    string input = Console.ReadLine();
    int time;
    while (!int.TryParse(input, out time) || time <= 0)
    {
      Console.WriteLine("Invalid input. Please enter a positive integer.");
      Console.Write("Enter the duration in seconds: ");
      input = Console.ReadLine();
    }
    return time;
  }

  public string GetEndingMessage()
  {
    return $"Well Done!!!\nYou have completed another {_Time} seconds of the {_ActivityName}";

  }

  public void Pause()
  {
    Console.Write("Get ready");
    for (int i = 5; i > 0; i--)
    {
      Console.Write(".");
      Thread.Sleep(1000);
    }

  }

  public void Animation()
  {
    List<string> Animation = new List<string>();
    Animation.Add("|");
    Animation.Add("/");
    Animation.Add("-");
    Animation.Add("\\");
    Animation.Add("|");
    Animation.Add("/");
    Animation.Add("-");
    Animation.Add("\\");

    foreach (string s in Animation)
    {
      Console.Write(s);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }

  }


}