using workflow;
using workflow.Contracts;

namespace TestProject
{
    public class UnitTestOperation2
    {
        private float _input;
        private float _expectedOutput;
        [SetUp]
        public void Setup()
        {
            _input = 3;
            _expectedOutput = 15;
        }

        [Test]
        public void Test1()
        {
            var operation = new Operation2();
            var result = operation.DoOperation(_input);
            Assert.AreEqual(_expectedOutput, result);
        }
    }
}