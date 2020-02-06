using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Dengue.Models
{
    public class LocationResult
    {
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }
        [JsonProperty(PropertyName = "probability 0-10")]
        public string probability1 { get; set; }
        [JsonProperty(PropertyName = "probability 11-21")]
        public string probability2 { get; set; }
        [JsonProperty(PropertyName = "probability 21-30")]
        public string probability3 { get; set; }
        [JsonProperty(PropertyName = "probability 31-40")]
        public string probability4 { get; set; }
        [JsonProperty(PropertyName = "probability 41-50")]
        public string probability5 { get; set; }
        [JsonProperty(PropertyName = "probability >51")]
        public string probability6 { get; set; }
    }
}
