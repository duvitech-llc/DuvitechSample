using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DuvitechSample.Data.Models
{
    public partial class HeartRate
    {
        [JsonProperty("activities-heart")]
        public List<ActivitiesHeart> ActivitiesHeart { get; set; }

        [JsonProperty("activities-heart-intraday")]
        public ActivitiesHeartIntraday ActivitiesHeartIntraday { get; set; }
    }

    public partial class ActivitiesHeartIntraday
    {
        [JsonProperty("dataset")]
        public List<object> Dataset { get; set; }

        [JsonProperty("datasetInterval")]
        public long DatasetInterval { get; set; }

        [JsonProperty("datasetType")]
        public string DatasetType { get; set; }
    }

    public partial class ActivitiesHeart
    {
        [JsonProperty("customHeartRateZones")]
        public List<object> CustomHeartRateZones { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("heartRateZones")]
        public List<HeartRateZone> HeartRateZones { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
    
    public partial class HeartRate
    {
        public static HeartRate FromJson(string json) => JsonConvert.DeserializeObject<HeartRate>(json, Converter.Settings);
    }
        
}
