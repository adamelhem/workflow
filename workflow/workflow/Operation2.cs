using workflow.Contracts;

namespace workflow
{
    public class Operation2 : IStrategy
    {
        public string Name => "operation 2";

        // Operation 2: Multiply the input number by 5. 
        public float DoOperation(float input) => input * 5;
    }
}
