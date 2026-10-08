using FormationCS;

namespace FormationTest
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
            var x = 1;
            x = x + 1;
            Assert.That(x, Is.EqualTo(2));
        }

        [Test]
        public void TestRectangle()
        {
            var r1 = new Rectangle(3, 2, new Point(0, 0));
            Assert.That(r1.Surface(), Is.EqualTo(6));
        }

    }
}