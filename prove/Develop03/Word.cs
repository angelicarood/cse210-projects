class Word
{
  private string _Value;
  private bool _Hidden;

  public Word(string word)
  {
    _Value = word;
    _Hidden = false;
  }
  public void Hide()
  {
    _Hidden = true;
  }

  public string WordString()
  {
    if (_Hidden == true)
    {
      return new string('_', _Value.Length);
    }
    else
    {
      return _Value;
    }
  }

  public string ActualWordString()
  {
    return _Value;
  }


}