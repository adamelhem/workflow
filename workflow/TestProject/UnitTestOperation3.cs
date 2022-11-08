using workflow;
using workflow.Contracts;

namespace TestProject
{
    public class UnitTestOperation3
    {
        private float _input;
        private float _expectedOutput;
        [SetUp]
        public void Setup()
        {
            _input = 6;
            _expectedOutput = 3;
        }

        [Test]
        public void Test1()
        {
            var operation = new Operation3();
            var result = operation.DoOperation(_input);
            Assert.AreEqual(_expectedOutput, result);
        }
    }
}