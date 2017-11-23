using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace DuvitechSample.Data.Models
{
    public partial class ActivitySummary
    {
        [JsonProperty("activities")]
        public List<object> Activities { get; set; }

        [JsonProperty("goals")]
        public Goals Goals { get; set; }

        [JsonProperty("summary")]
        public Summary Summary { get; set; }
    }

    public partial class Summary
    {
        [JsonProperty("activeScore")]
        public double ActiveScore { get; set; }

        [JsonProperty("activityCalories")]
        public long ActivityCalories { get; set; }

        [JsonProperty("caloriesBMR")]
        public long CaloriesBMR { get; set; }

        [JsonProperty("caloriesOut")]
        public long CaloriesOut { get; set; }

        [JsonProperty("distances")]
        public List<Distance> Distances { get; set; }

        [JsonProperty("elevation")]
        public long Elevation { get; set; }

        [JsonProperty("fairlyActiveMinutes")]
        public long FairlyActiveMinutes { get; set; }

        [JsonProperty("floors")]
        public long Floors { get; set; }

        [JsonProperty("heartRateZones")]
        public List<HeartRateZone> HeartRateZones { get; set; }

        [JsonProperty("lightlyActiveMinutes")]
        public long LightlyActiveMinutes { get; set; }

        [JsonProperty("marginalCalories")]
        public long MarginalCalories { get; set; }

        [JsonProperty("restingHeartRate")]
        public long RestingHeartRate { get; set; }

        [JsonProperty("sedentaryMinutes")]
        public long SedentaryMinutes { get; set; }

        [JsonProperty("steps")]
        public long Steps { get; set; }

        [JsonProperty("veryActiveMinutes")]
        public long VeryActiveMinutes { get; set; }
    }

    public partial class HeartRateZone
    {
        [JsonProperty("caloriesOut")]
        public double CaloriesOut { get; set; }

        [JsonProperty("max")]
        public long Max { get; set; }

        [JsonProperty("min")]
        public long Min { get; set; }

        [JsonProperty("minutes")]
        public long Minutes { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Distance
    {
        [JsonProperty("activity")]
        public string Activity { get; set; }

        [JsonProperty("distance")]
        public long PurpleDistance { get; set; }
    }

    public partial class Goals
    {
        [JsonProperty("activeMinutes")]
        public long ActiveMinutes { get; set; }

        [JsonProperty("caloriesOut")]
        public long CaloriesOut { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("floors")]
        public long Floors { get; set; }

        [JsonProperty("steps")]
        public long Steps { get; set; }
    }

    public partial class ActivitySummary
    {
        public static ActivitySummary FromJson(string json) => JsonConvert.DeserializeObject<ActivitySummary>(json, Converter.Settings);
    }
        
}
