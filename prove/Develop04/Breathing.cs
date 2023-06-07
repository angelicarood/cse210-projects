public class Breathing : Mindfulness
{
  private string _BreatheIn;
  private string _BreatheOut;

  public Breathing(string activityname, int time, string description, string breathein, string breatheout) : base(activityname, time, description)
  {
    _BreatheIn = breathein;
    _BreatheOut = breatheout;

  }
  public void BreathingActivity()
  {
    Console.WriteLine(GetStartMessage());

    int duration = GetTimeUser();
    Pause();

    Console.WriteLine();

    DateTime startTime = DateTime.Now;
    int secondsElapsed = 0;
    Console.WriteLine();

    while (secondsElapsed < duration)
    {
      Console.WriteLine("Breathe in...");
      Animation();
      Console.WriteLine();
      Console.WriteLine("Breathe out...");
      Animation();

      secondsElapsed = (int)(DateTime.Now - startTime).TotalSeconds;
      Console.Clear(); // Clear the console after each breath to provide a smoother animation effect
    }
    Animation();
    Console.WriteLine(GetEndingMessage());
  }
}