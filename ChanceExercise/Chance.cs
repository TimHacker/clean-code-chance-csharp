using System.Diagnostics;
using System.Globalization;

namespace ChanceExercise;

public class Chance
{
    private readonly double _likelihood;

    public Chance(double likelihood)
    {
        _likelihood = likelihood;
    }
    
    public bool Equals(Chance other)
    {
        return Math.Abs(_likelihood - other._likelihood) < 0.00001;
    }

    public override bool Equals(object? o)
    {
        if (o is Chance other)
        {
            return Equals(other);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return _likelihood.GetHashCode();
    }

    public Chance And(Chance other)
    {
        return new Chance(_likelihood * other._likelihood);
    }

    public Chance Or(Chance other)
    {
        return new Chance(_likelihood + other._likelihood);
    }

    public override string ToString()
    {
        return _likelihood.ToString(CultureInfo.InvariantCulture);
    }
}