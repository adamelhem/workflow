using workflow.Contracts;

namespace workflow
{

    //the next id to run if the output is < 10
    //the next id to run if the output is >= 10
    //if the output number is exactly 10 – the workflow stops
    public class StepsManager : IStepsManager
    {
        private Step[] _steps;
        private IStrategy[] _operations;

        public StepsManager(Step[] steps, IStrategy[] operations)
        {
            this._steps = steps;
            this._operations = operations;
        }

        public StepResult GetNextStep(float number, Step step)
        {
            try
            {
                var nextOperationName = step.operationName;
                var nextOperation = _operations.First(o => o.Name == nextOperationName);
                var operationResult = nextOperation.DoOperation(number);

                //  The next id to run if the output is < 10 
                if (operationResult < 10)
                {
                    var nextId = step.nextIdIfOutputIsLessThan;
                    var nextStep = this._steps.First(s => s.id == nextId);
                    return new StepResult
                    {
                        NextStep = nextStep,
                        OutputNumber = operationResult
                    };
                }

                // The next id to run if the output is >= 10 
                else if (operationResult >= 10)
                {
                    var nextId = step.nextIdIfOutputIsGreaterThan;
                    var nextStep = this._steps.First(s => s.id == nextId);
                    return new StepResult
                    {
                        NextStep = nextStep,
                        OutputNumber = operationResult
                    };
                }

                // If the output number is exactly 10 – the workflow stops 
                return new StepResult
                {
                    NextStep = new Step { id = -1 }
                };
            }
            catch
            {
                // If there is an exception then stop the flow
                return new StepResult
                {
                    NextStep = new Step { id = -1 }
                };
            }

        }
    }
}