public abstract class Activity
{
  private DateTime _date;
 
  private double _length;

  public Activity(DateTime date, double length)
  {
    _date = date;
    _length = length;
  }

  public double length => _length;
  public DateTime date => _date;

  public abstract double Distance();
  public abstract double Speed();
  public abstract double Pace();

  public string GetSummary()
    {
    return $"{_date:dd MMM yyyy} {GetType().Name} ({_length} min) - " +
             $"Distance: {Distance():0.0} km, Speed: {Speed():0.0} kph, Pace: {Pace():0.0} min per km";
    }
 
  
}