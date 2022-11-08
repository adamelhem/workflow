using workflow.Contracts;

namespace workflow
{
    public class Operation1 : IStrategy
    {
        public string Name => "operation 1";

        // Operation 1: Adds 3 to the input number.
        public float DoOperation(float input) => input + 3;
    }
}