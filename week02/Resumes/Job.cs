

public class Job
{
  public string _company;
  public string _jobtTitle;
  public int _startYear;
  public int _endYear ;
  // public Job(){}

  public void DisplayJobDetails() {
    Console.WriteLine($"{_jobtTitle} ({_company}) {_startYear} - {_endYear}");
  }

}