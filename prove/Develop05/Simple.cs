public class Simple : Goal
{
  public Simple(string name, string description, int points)
    : base(name, description, points)
  {
  }

  public override void RecordEvent()
  {
    _Progress = _Points;
  }
}