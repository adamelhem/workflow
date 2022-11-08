using Newtonsoft.Json;
using workflow.Contracts;

namespace workflow
{
    public class Helper : IHelper
    {
        public T LoadJsonFile<T>(string filePath)
        {
            var json = File.ReadAllText(filePath);
            var serializer = new JsonSerializer();
            var data = JsonConvert.DeserializeObject<T>(json);
            return data;
        }
    }
}