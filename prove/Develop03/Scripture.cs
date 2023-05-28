

class Scripture
{
  private List<string> _ActualVerses;
  private Reference _Reference;
  private List<Word> _WordList;
  private List<int> _NotHiddenWordIndexes;


  public Scripture()
  {
    _ActualVerses = new List<string>();
    string[] lines = File.ReadAllLines("/Users/angelicaleon/repos/cse210-projects/prove/Develop03/Ether3.txt");
    _ActualVerses.AddRange(lines);
  }

  public void SelectVerses(int start, int end)
  {
    List<int> orderedNumberList = new List<int>();
    _NotHiddenWordIndexes = new List<int>();
    _WordList = new List<Word>();
    _Reference = new Reference(start, end);
    string verses = _ActualVerses[start - 1];
    for (int i = start; i < end; i++)
    {
      verses = verses + " " + _ActualVerses[i];
    }
    string[] words = verses.Split();
    for (int i = 0; i < words.Length; i++)
    {
      orderedNumberList.Add(i);
      _WordList.Add(new Word(words[i]));
    }

    //randomizing list code from SO: https://stackoverflow.com/questions/273313/randomize-a-listt
    Random rand = new Random();
    _NotHiddenWordIndexes = orderedNumberList.OrderBy(a => rand.Next()).ToList();


  }

  public void PrintVerse()
  {
    //Print out the reference
    Console.WriteLine(_Reference.FormatString());
    Console.WriteLine();
    foreach (Word word in _WordList)
    {
      //Print out words
      Console.Write(word.WordString() + " ");

    }




  }
  public void RemoveWords()
  {
    for (int i = 0; i < 3; i++)
    {
      if (_NotHiddenWordIndexes.Count < 1)
      {
        return;
      }

      int index = _NotHiddenWordIndexes[0];
      _NotHiddenWordIndexes.RemoveAt(0);
      _WordList[index].Hide();
    }

  }

  public bool IsEverythingBlank()
  {
    if (_NotHiddenWordIndexes.Count == 0)
    {


      return true;

    }

    else
    {
      return false;
    }
  }



}








