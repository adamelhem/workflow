namespace workflow
{
    public class Operation1 : IStrategy
    {
        // Operation 1: Adds 3 to the input number.
        public float DoOperation(float input) => input + 3;
    }
}