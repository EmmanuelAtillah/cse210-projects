public class Fraction
{
    private int _top;
    private int _bottom;

    //  //getters
    // public int GetTop()
    // {
    //     return _top;
    //  }
    // public int GetBottom()
    // {
    //     return _bottom;
    //  }
    //  //setters
    // public void SetTop()
    // {
    //     _top = _top;
    // }
    // public void SetBottom()
    // {
    //     _bottom = _bottom;
    // }
    
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }


    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }


    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }
    public double GetDecimalValue()
    {
        double decValue = (double)_top / (double)_bottom;
        return decValue;

     }


}
