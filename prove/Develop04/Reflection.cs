public class Reflection : Mindfulness
{
  private List<string> _ReflectionPrompts = new List<string>();
  private List<string> _Questions = new List<string>();

  public Reflection(string activityname, int time, string description) : base(activityname, time, description)
  {
    _ReflectionPrompts = new List<string>{"Think of a time when you stood up for someone else.",
"Think of a time when you did something really difficult.",
"Think of a time when you helped someone in need.",
"Think of a time when you did something truly selfless."};
    _Questions = new List<string>{"Why was this experience meaningful to you?",
"Have you ever done anything like this before?",
"How did you get started?",
"How did you feel when it was complete?",
"What made this time different than other times when you were not as successful?",
"What is your favorite thing about this experience?",
"What could you learn from this experience that applies to other situations?",
"What did you learn about yourself through this experience?",
"How can you keep this experience in mind in the future?"

  };
  }
  public string GetRandomPrompt()

  {
    Random random = new Random();
    int index = random.Next(_ReflectionPrompts.Count);
    return _ReflectionPrompts[index];
  }

  public void ReflectionActivity()
  {
    Console.WriteLine(GetStartMessage());
    Console.WriteLine();

    int duration = GetTimeUser();
    Console.WriteLine();
    Pause();
    DateTime startTime = DateTime.Now;
    int secondsElapsed = 0;

    Console.WriteLine();

    while (secondsElapsed < duration)
    {
      string prompt = GetRandomPrompt();
      Console.WriteLine(prompt);
      Console.WriteLine();
      Pause();
      Console.WriteLine();

      foreach (string question in _Questions)
      {
        Console.WriteLine(question);
        Animation();
      }

      secondsElapsed = (int)(DateTime.Now - startTime).TotalSeconds;
    }
    Animation();
    Console.WriteLine();
    Console.WriteLine(GetEndingMessage());
  }
}