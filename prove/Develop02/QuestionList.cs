public class QuestionList
{

  public List<string> listPrompts = new List<string>();


  public QuestionList()
  {
    listPrompts = new List<string>{"What is one thing you want to remember from today?",
  "What are three things you are grateful for today?",
  "How do you show people that you love them?",
  "What country would you like to visit for the first time?",
  "What truths have you uncovered in the past year?",
  "What is your happy place? Describe it in detail"};

  }

  public string GetRandomQuestion()
  {
    Random random = new Random();
    int index = random.Next(listPrompts.Count);
    return listPrompts[index];
  }
}



