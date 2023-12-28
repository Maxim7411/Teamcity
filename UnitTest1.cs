using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(Program.GetNthPrime(3)==5);
        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue(Program.GetNthPrime(4) == 7);
        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(Program.GetNthPrime(5) == 11);
        }
    }

}