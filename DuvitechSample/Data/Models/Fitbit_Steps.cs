using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace DuvitechSample.Data.Models
{
    public partial class Fitbit_Steps
    {
        [JsonProperty("activities-steps")]
        public List<ActivitiesStep> ActivitiesSteps { get; set; }

        [JsonProperty("activities-steps-intraday")]
        public ActivitiesStepsIntraday ActivitiesStepsIntraday { get; set; }
    }

    public partial class ActivitiesStepsIntraday
    {
        [JsonProperty("dataset")]
        public List<Dataset> Dataset { get; set; }

        [JsonProperty("datasetInterval")]
        public long DatasetInterval { get; set; }

        [JsonProperty("datasetType")]
        public string DatasetType { get; set; }
    }

    public partial class Dataset
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }
    }

    public partial class ActivitiesStep
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class Fitbit_Steps
    {
        public static Fitbit_Steps FromJson(string json) => JsonConvert.DeserializeObject<Fitbit_Steps>(json, Converter.Settings);
    }

}
