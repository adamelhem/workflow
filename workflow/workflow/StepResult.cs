using workflow.Contracts;

namespace workflow
{
    public class StepResult
    {
        public Step NextStep { get; set; }
        public float OutputNumber { get; set; }
    }
}
