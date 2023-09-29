using NUnit.Framework;
using Taschenrechner;

namespace TestTaschenrechner;

public class Tests
{
    [Test]
    public void TestAddition()
    {
        int ErwartetesErgebniss = 10;
        int zahl1 = 5;
        int zahl2 = 5;
        int Ergebniss = Program.Addition(zahl1, zahl2);
        Assert.AreEqual(ErwartetesErgebniss , Ergebniss);
    }
    [Test]
    public void TestSubtraktion()
    {
        int ErwartetesErgebniss = 10;
        int zahl1 = 11;
        int zahl2 = 1;
        int Ergebniss = Program.Subtraktion(zahl1, zahl2);
        Assert.AreEqual(ErwartetesErgebniss , Ergebniss);
    }
    [Test]
    public void TestMultiplikation()
    {
        int ErwartetesErgebniss = 10;
        int zahl1 = 5;
        int zahl2 = 2;
        int Ergebniss = Program.Multiplikation(zahl1, zahl2);
        Assert.AreEqual(ErwartetesErgebniss , Ergebniss);
    }
    [Test]
    public void TestDivision()
    {
        int ErwartetesErgebniss = 10;
        int zahl1 = 20;
        int zahl2 = 2;
        int Ergebniss = Program.Division(zahl1, zahl2);
        Assert.AreEqual(ErwartetesErgebniss , Ergebniss);
    }
}