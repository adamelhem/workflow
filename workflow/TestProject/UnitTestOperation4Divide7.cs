using workflow;
using workflow.Contracts;

namespace TestProject
{
    public class UnitTestOperation4Divide7
    {
        private float _input;

        [SetUp]
        public void Setup()
        {
            _input = 14;
        }

        [Test]
        public void Test1()
        {
            var operation = new Operation4();
            try
            {
                var result = operation.DoOperation(_input);
                Assert.Fail();
            }
            catch
            {
            }
        }
    }
}