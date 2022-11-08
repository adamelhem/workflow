using workflow.Contracts;

namespace workflow
{
    public class Operation3 : IStrategy
    {
        public string Name => "operation 3";

        // Operation 3: Divide the input number by 2. 
        public float DoOperation(float input) => input / 2;
    }
}
