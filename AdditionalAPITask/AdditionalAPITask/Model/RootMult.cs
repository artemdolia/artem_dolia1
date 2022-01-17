using Newtonsoft.Json;
using System.Collections.Generic;
using static AdditionalAPITask.Model.EmployeeModel;

namespace AdditionalAPITask.Model
{
    public class RootMult
    {
        [JsonProperty("status")]
        public string status { get; set; }
        [JsonProperty("data")]
        public List<Data> data { get; set; }
    }
}
