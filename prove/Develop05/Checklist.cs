public class Checklist : Goal
{
  private int requiredCount;
  private int bonusPoints;

  public Checklist(string name, string description, int points, int requiredCount)
      : base(name, description, points)
  {
    this.requiredCount = requiredCount;
    this.bonusPoints = points * requiredCount;
  }

  public override void RecordEvent()
  {
    if (_Progress < requiredCount)
    {
      _Progress++;
    }
  }

  public int GetBonusPoints()
  {
    if (IsCompleted())
    {
      return bonusPoints;
    }

    return 0;
  }

  public bool IsCompleted()
  {
    return _Progress >= requiredCount;
  }

  public override string ToString()
  {
    string progressText = $"Completed {_Progress}/{requiredCount} times";
    if (IsCompleted())
    {
      progressText += " [Completed]";
    }
    else
    {
      progressText += $" [Incomplete]";
    }

    return $"{base.ToString()} {progressText}";
  }
}