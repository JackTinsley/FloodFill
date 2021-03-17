using NUnit.Framework;
using System.Drawing;

namespace FloodFillTests
{
    public class Tests
    {
        [Test]
        public void SampleOneGivesExpectedOutput()
        {
            var floodFiller = new FloodFiller(SampleInputs.SampleOne);
            var output = floodFiller.Fill(new Point(2, 2), '@', false);

            Assert.That(output, Is.EqualTo(SampleInputs.OutputOne));
        }

        [Test]
        public void SampleTwoGivesExpectedOutput()
        {
            var floodFiller = new FloodFiller(SampleInputs.SampleTwo);
            var output = floodFiller.Fill(new Point(8, 3), ',', false);

            Assert.That(output, Is.EqualTo(SampleInputs.OutputTwo));
        }

        [Test]
        public void SampleThreeGivesExpectedOutput()
        {
            var floodFiller = new FloodFiller(SampleInputs.SampleThree);
            var output = floodFiller.Fill(new Point(1, 7), '#', true);

            Assert.That(output, Is.EqualTo(SampleInputs.OutputThree));
        }
    }
}