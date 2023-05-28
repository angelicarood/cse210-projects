class Reference
{
  private string _Book = "Ether";
  private int _Chapter = 3;
  private int _StartingVerse;
  private int _EndingVerse;

  public Reference(int staringVerse, int endingVerse)
  {
    _StartingVerse = staringVerse;
    _EndingVerse = endingVerse;
  }

  public Reference(int verse)
  {
    _StartingVerse = verse;
    _EndingVerse = verse;
  }

  public string FormatString()
  {
    if (_StartingVerse == _EndingVerse)
    {
      return $"{_Book} {_Chapter}:{_StartingVerse} ";
    }

    return $"{_Book} {_Chapter}:{_StartingVerse}-{_EndingVerse}";
  }

  public int GetStartingVerse()
  {
    return _StartingVerse;
  }


  public int GetEndingVerse()
  {
    return _EndingVerse;
  }


}
