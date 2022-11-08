using workflow;
using workflow.Contracts;

namespace TestProject
{
    public class UnitTestOperation1
    {
        private float _input;
        private float _expectedOutput;

        [SetUp]
        public void Setup()
        {
            _input = 3;
            _expectedOutput = 6;
        }

        [Test]
        public void Test1()
        {
            var operation = new Operation1();
            var result = operation.DoOperation(_input);
            Assert.AreEqual(_expectedOutput, result);
        }
    }
}