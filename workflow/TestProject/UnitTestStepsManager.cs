using workflow;
using workflow.Contracts;

namespace TestProject
{
    public class UnitTestStepsManager
    { 
        Step[] _steps ;
        IStrategy[]  _operations;
        StepResult _inputResult;
        float _expectedOutputNumber;
        int _expectedOutStepId;

        [SetUp]
        public void Setup()
        {
            _expectedOutputNumber = 8;
            _expectedOutStepId = 1;
            _operations = new IStrategy[] {
                new Operation1(),
                new Operation2(),
                new Operation3(),
                new Operation4()
                };

            _steps = new Step[] 
            {
                new Step
                {
                    id = 1,
                    operationName = "operation 1",
                    nextIdIfOutputIsLessThan = 1,
                    nextIdIfOutputIsGreaterThan = 2
                },
                new Step
                {
                    id = 2,
                    operationName = "operation 3",
                    nextIdIfOutputIsLessThan = 5,
                    nextIdIfOutputIsGreaterThan = 3
                },
                new Step
                {
                    id = 3,
                    operationName = "operation 4",
                    nextIdIfOutputIsLessThan = 1,
                    nextIdIfOutputIsGreaterThan = 3
                }};

            _inputResult = new StepResult()
            {
                NextStep = new Step
                {
                    id = 1,
                    operationName = "operation 1",
                    nextIdIfOutputIsLessThan = 1,
                    nextIdIfOutputIsGreaterThan = 2
                },
                OutputNumber = 5,
            };

        }

        [Test]
        public void Test1()
        {
            var stepsManager = new StepsManager(_steps, _operations);
            var result = stepsManager.GetNextStep(_inputResult.OutputNumber, _steps[0]);
            Assert.AreEqual(_expectedOutputNumber, result.OutputNumber);
            Assert.AreEqual(_expectedOutStepId, result.NextStep.id);
        }
    }
}