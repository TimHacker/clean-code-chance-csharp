namespace ChanceExercise;

public class Tests
{
    [Test]
    public void TwoEqualChancesAreEqual()
    {
        Assert.That(new Chance(0.6).Equals(new Chance(0.6)));
    }
    
    [Test]
    public void TwoUnequalChancesAreNotEqual()
    {
        Assert.That(new Chance(0.6), Is.Not.EqualTo(new Chance(0.3)));
    }
    
    [Test]
    public void AndMultipliesTheLikelihoods()
    {
        Assert.That(new Chance(0.6).And(new Chance(0.3)), 
            Is.EqualTo(new Chance(0.18)));
    }
    
    [Test]
    public void AndIsCommutative()
    {
        Assert.That(new Chance(0.6).And(new Chance(0.3)), 
            Is.EqualTo(new Chance(0.3).And(new Chance(0.6))));
    }
    
    [Test]
    public void OrAddsTheLikelihoods()
    {
        Assert.That(new Chance(0.6).Or(new Chance(0.3)), 
            Is.EqualTo(new Chance(0.9)));
    }

    [Test]
    public void SimilarChancesAreConsideredEqual()
    {
        Assert.That(new Chance(5.00000).Equals(new Chance((5.000001))));
    }
    
    // Should we test that we didn't go overboard with the tolerance i.e. 5.1 is not equal to 5.0
}