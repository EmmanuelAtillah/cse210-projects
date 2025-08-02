public class Assignment
{
  private string _stufentName;
  private string _topic;

  public Assignment(string studentName, string topic)
  {
    _stufentName = studentName;
    _topic = topic;

  }



  public string GetSummary()
  {
    return $"{_stufentName} - {_topic}";
  }

    public string GetName()
  {
    return _stufentName;
  }



}