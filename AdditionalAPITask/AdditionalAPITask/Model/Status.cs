using Newtonsoft.Json;

namespace AdditionalAPITask.Model
{
    public class Status
    {
        [JsonProperty("status")]
        public string status { get; set; }
    }
}
