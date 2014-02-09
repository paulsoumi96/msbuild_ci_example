using NUnit.Framework;

namespace msbuild_ci_example.tests
{
    [TestFixture]
    class ProgramTests
    {
        [Test]
        public void ShouldBeADummyTest()
        {
            Assert.That(true, Is.True);
        }
    }
}
