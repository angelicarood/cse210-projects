public class Listing : Mindfulness
{
  private List<string> _PromptList = new List<string>();
  private List<string> _ItemsList = new List<string>();

  public Listing(string activityname, int time, string description) : base(activityname, time, description)
  {
    _PromptList = new List<string>{"Who are people that you appreciate?",
"What are personal strengths of yours?",
"Who are people that you have helped this week?",
"When have you felt the Holy Ghost this month?",
"Who are some of your personal heroes?"};
    _ItemsList = new List<string>();
  }
  public string GetRandomPromptList()
  {

    Random random = new Random();
    int index = random.Next(_PromptList.Count);
    return _PromptList[index];
  }
  public void ListingActivity()
  {
    Console.WriteLine(GetStartMessage());
    Console.WriteLine();
    int duration = GetTimeUser(); // Get the duration from user input
    Console.WriteLine();
    Pause();
    Console.WriteLine();

    string prompt = GetRandomPromptList();
    Console.WriteLine(prompt);
    Console.WriteLine("Begin listing items:");

    int secondsElapsed = 0;
    DateTime startTime = DateTime.Now;

    while (secondsElapsed < duration)
    {
      string item = Console.ReadLine();
      _ItemsList.Add(item);

      secondsElapsed = (int)(DateTime.Now - startTime).TotalSeconds;
    }
    Animation();
    Console.WriteLine();
    Console.WriteLine($"You listed {_ItemsList.Count} items.");
    Animation();
    Console.WriteLine();
    Console.WriteLine(GetEndingMessage());
  }
}