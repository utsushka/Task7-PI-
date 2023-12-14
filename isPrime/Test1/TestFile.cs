using static Program;
namespace isPrime
    //Стопапупа
{
    public class Tests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Test1() { Assert.IsTrue(IsPrime(3)); }

        [Test]
        public void Test2() { Assert.IsTrue(IsPrime(73)); }

        [Test]
        public void Test3() { Assert.IsFalse(IsPrime(6)); }
    }
}