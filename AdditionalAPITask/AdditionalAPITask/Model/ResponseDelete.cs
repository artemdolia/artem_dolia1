using Newtonsoft.Json;

namespace AdditionalAPITask.Model
{
    public class ResponseDelete
    {
        [JsonProperty("status")]
        public string status { get; set; }
        [JsonProperty("message")]
        public string message { get; set; }
    }
}
