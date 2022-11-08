namespace workflow.Contracts
{
    public interface IHelper
    {
        T LoadJsonFile<T>(string filePath);
    }
}