
using Newtonsoft.Json;


namespace CheckIn_Event
{
    public class Customer
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("data")]
        public CustomerDetails Data { get; set; }
    }

    public class CustomerDetails
    {
        [JsonProperty("customer")]
        public CustomerInfo Customer { get; set; }

        [JsonProperty("audio")]
        public string Audio { get; set; }
    }

    public class CustomerInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("gender")]
        public string gender { get; set; }

        [JsonProperty("image")]
        public string image { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("office")]
        public string office { get; set; }

        [JsonProperty("unit")]
        public string unit { get; set; }

        [JsonProperty("created_at")]
        public string created_at { get; set; }

        [JsonProperty("updated_at")]
        public string updated_at { get; set; }
    }
}
