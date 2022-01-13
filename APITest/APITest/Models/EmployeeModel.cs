using Newtonsoft.Json;
using System.Collections.Generic;

namespace APITest.Models
{
    public class Data
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("employee_name")]
        public string employee_name { get; set; }
        [JsonProperty("employee_salary")]
        public string employee_salary { get; set; }
        [JsonProperty("employee_age")]
        public string employee_age { get; set; }
        [JsonProperty("profile_image")]
        public string profile_image { get; set; }
        [JsonProperty("message")]
        public string message { get; set; }
    }

    public class RootMult
    {
        [JsonProperty("status")]
        public string status { get; set; }
        [JsonProperty("data")]
        public List<Data> data { get; set; }
    }

    public class RootSingle
    {
        [JsonProperty("status")]
        public string status { get; set; }
        [JsonProperty("data")]
        public Data data { get; set; }
    }

    public class Status
    {
        [JsonProperty("status")]
        public string status { get; set; }
    }
}
