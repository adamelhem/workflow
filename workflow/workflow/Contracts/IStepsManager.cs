namespace workflow.Contracts
{
    public interface IStepsManager
    {
        StepResult GetNextStep(float number, Step step);
    }
}