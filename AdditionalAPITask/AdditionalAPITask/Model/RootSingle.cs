using Newtonsoft.Json;
using static AdditionalAPITask.Model.EmployeeModel;

namespace AdditionalAPITask.Model
{
    public class RootSingle
    {
        [JsonProperty("status")]
        public string status { get; set; }
        [JsonProperty("data")]
        public Data data { get; set; }
    }
}

