public class Swimming : Activity
{
  private int _swimmingLaps;
  public Swimming(DateTime date, int lenght, int swimmingLaps) : base(date, lenght)
  {
    _swimmingLaps = swimmingLaps;
  }

  public override double Distance()
  {
    double distance =( _swimmingLaps * 50) / 1000;
    return distance;
  }

  public override double Speed()
  {
    double distance = Distance();
    return (distance / length) * 60;

  }

  public override double Pace()
  {
     double distance = Distance();
    return length / distance;
  }

}
