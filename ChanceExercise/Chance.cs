using System.Globalization;

namespace ChanceExercise;

public class Chance
{
    private const double THRESHOLD = 0.00001;
    private readonly double _likelihood;

    public Chance(double likelihood)
    {
        _likelihood = likelihood;
    }
    
    public bool Equals(Chance other)
    {
        return Math.Abs(_likelihood - other._likelihood) < THRESHOLD;
    }

    public override bool Equals(object? o)
    {
        if (o is not Chance other)
        {
            return false;
        }

        return Equals(other);
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