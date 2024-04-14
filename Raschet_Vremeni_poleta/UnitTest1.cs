namespace Raschet_Vremeni_poleta;

public class Tests
{
    [SetUp]
    public void Setup()
    {

        
    }
    private double CalcT(double v, double g)
    {
        return  2 * v / g;
    }

    [Test]
    public void TestWhenVisHalfofG()
    {
        double v = 4.9;
        double g = 9.8;
        double t = 2 * v / g;

        double calcT = CalcT(v, g);
        
        Assert.AreEqual(t, calcT, 1);

    }
    
    [Test]
    public void TestWhenVisNull()
    {
        double v = 0;
        double g = 9.8;
        double t = 2 * v / g;

        double calcT = CalcT(v, g);
        
        Assert.AreEqual(t, calcT, 0);

    }
}