public class Cycling : Activity
{
  private int _distance;
  public Cycling(DateTime date, int length, int distance) : base(date, length)
  {
    _distance = distance;
  }

  public override double Distance()
  {
    return _distance;
  }

  public override double Speed()
  {
    return (_distance / length) * 60;

  }

  public override double Pace()
  {
    return length / _distance;
  }
  

}