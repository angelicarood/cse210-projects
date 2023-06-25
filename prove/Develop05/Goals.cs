public abstract class Goal
{
  public string _Name { get; set; }
  public string _Description { get; set; }
  public int _Points { get; set; }
  public int _Progress { get; set; }

  public Goal(string name, string description, int points)
  {
    _Name = name;
    _Description = description;
    _Points = points;
    _Progress = 0;
  }

  public abstract void RecordEvent();

  public int GetProgress()
  {
    return _Progress;
  }

  public override string ToString()
  {
    return $"{GetType().Name}: {_Name} - {_Description} [Progress: {_Progress}/{_Points}]";
  }
}
