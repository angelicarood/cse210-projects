
public class GoalManager
{
  private List<Goal> goals;
  private int score;

  public GoalManager()
  {
    goals = new List<Goal>();
    score = 0;
  }

  public void AddGoal(Goal goal)
  {
    goals.Add(goal);
  }

  public int GetScore()
  {
    return score;
  }

  public void SaveGoals(string filename)
  {
    using (StreamWriter writer = new StreamWriter(filename))
    {
      foreach (Goal goal in goals)
      {
        string goalData = $"{goal.GetType().Name},{goal._Name},{goal._Description},{goal._Points},{goal.GetProgress()}";
        writer.WriteLine(goalData);
      }
    }

    Console.WriteLine("Goals saved successfully.");
  }

  public void LoadGoals(string filename)
  {
    goals.Clear();

    using (StreamReader reader = new StreamReader(filename))
    {
      string line;
      while ((line = reader.ReadLine()) != null)
      {
        string[] goalData = line.Split(',');
        string goalType = goalData[0];
        string name = goalData[1];
        string description = goalData[2];
        int points = int.Parse(goalData[3]);

        switch (goalType)
        {
          case "Simple":
            goals.Add(new Simple(name, description, points));
            break;
          case "Eternal":
            goals.Add(new Eternal(name, description, points));
            break;
          case "Checklist":
            int requiredCount = int.Parse(goalData[4]);
            goals.Add(new Checklist(name, description, points, requiredCount));
            break;
          default:
            Console.WriteLine($"Unknown goal type: {goalType}. Skipping...");
            break;
        }
      }
    }

    Console.WriteLine("Goals loaded successfully.");
  }

  public void RecordGoal(int index)
  {
    if (index >= 0 && index < goals.Count)
    {
      Goal goal = goals[index];
      goal.RecordEvent();
      score += goal._Points;

      if (goal is Checklist checklist && checklist.IsCompleted())
      {
        score += checklist.GetBonusPoints();
      }

      Console.WriteLine("Goal recorded successfully.");
    }
    else
    {
      Console.WriteLine("Invalid goal index.");
    }
  }

  public void DisplayGoals()
  {
    if (goals.Count == 0)
    {
      Console.WriteLine("No goals found.");
      return;
    }

    Console.WriteLine("Goals:");
    for (int i = 0; i < goals.Count; i++)
    {
      Goal goal = goals[i];
      Console.WriteLine($"{i + 1}. {goal}");
    }
  }
}
