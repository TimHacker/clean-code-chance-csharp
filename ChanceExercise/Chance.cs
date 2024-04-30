using System.Diagnostics;

namespace ChanceExercise;

public class Chance
{
    private readonly double _likelihood;

    public Chance(double likelihood)
    {
        _likelihood = likelihood;
    }

    public override bool Equals(object? o)
    {
        if (o is Chance other)
        {
            return Math.Abs(_likelihood - other._likelihood) < 0.00001;
        }
        return false;
    }

    public Chance And(Chance other)
    {
        return new Chance(_likelihood * other._likelihood);
    }

    public Chance Or(Chance other)
    {
        return new Chance(_likelihood + other._likelihood);
    }
}