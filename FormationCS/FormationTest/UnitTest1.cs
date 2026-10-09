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

        [Test]
        public void TestLinq()
        {
            var r1 = new Rectangle(3, 2, new Point(0, 0));
            var s1 = new Square(2, new Point(0, 0));
            var t1 = new TriangleRectangle(3, 2, new Point(0, 0));
            var formes = new List<Rectangle>([r1, s1, t1]);
            var result = formes.Where(f => f.Surface() > 4).OrderBy(f => f.Perimetre()).ToList();
            Assert.That(result.Count, Is.EqualTo(1));
        }

    }
}