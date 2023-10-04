namespace TestProject;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        TestClass test = new TestClass();
        Assert.AreEqual("名前", test.name);
    }

    [TestMethod]
    public void TestMethod2()
    {
        TestClass test = new TestClass();
        Assert.AreNotEqual("名前!", test.name);
    }
}