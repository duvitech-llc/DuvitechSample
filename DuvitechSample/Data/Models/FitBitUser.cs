using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace DuvitechSample.Data.Models
{
    public partial class FitbitUser
    {
        [JsonProperty("user")]
        public FBUser FBUser { get; set; }
    }

    public partial class FBUser
    {
        [JsonProperty("age")]
        public long Age { get; set; }

        [JsonProperty("ambassador")]
        public bool Ambassador { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("avatar150")]
        public string Avatar150 { get; set; }

        [JsonProperty("avatar640")]
        public string Avatar640 { get; set; }

        [JsonProperty("averageDailySteps")]
        public long AverageDailySteps { get; set; }

        [JsonProperty("clockTimeDisplayFormat")]
        public string ClockTimeDisplayFormat { get; set; }

        [JsonProperty("corporate")]
        public bool Corporate { get; set; }

        [JsonProperty("corporateAdmin")]
        public bool CorporateAdmin { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("displayNameSetting")]
        public string DisplayNameSetting { get; set; }

        [JsonProperty("distanceUnit")]
        public string DistanceUnit { get; set; }

        [JsonProperty("encodedId")]
        public string EncodedId { get; set; }

        [JsonProperty("features")]
        public Features Features { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("foodsLocale")]
        public string FoodsLocale { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("glucoseUnit")]
        public string GlucoseUnit { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("heightUnit")]
        public string HeightUnit { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("memberSince")]
        public string MemberSince { get; set; }

        [JsonProperty("mfaEnabled")]
        public bool MfaEnabled { get; set; }

        [JsonProperty("offsetFromUTCMillis")]
        public double OffsetFromUTCMillis { get; set; }

        [JsonProperty("startDayOfWeek")]
        public string StartDayOfWeek { get; set; }

        [JsonProperty("strideLengthRunning")]
        public double StrideLengthRunning { get; set; }

        [JsonProperty("strideLengthRunningType")]
        public string StrideLengthRunningType { get; set; }

        [JsonProperty("strideLengthWalking")]
        public double StrideLengthWalking { get; set; }

        [JsonProperty("strideLengthWalkingType")]
        public string StrideLengthWalkingType { get; set; }

        [JsonProperty("swimUnit")]
        public string SwimUnit { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("topBadges")]
        public TopBadge[] TopBadges { get; set; }

        [JsonProperty("waterUnit")]
        public string WaterUnit { get; set; }

        [JsonProperty("waterUnitName")]
        public string WaterUnitName { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("weightUnit")]
        public string WeightUnit { get; set; }
    }

    public partial class TopBadge
    {
        [JsonProperty("badgeGradientEndColor")]
        public string BadgeGradientEndColor { get; set; }

        [JsonProperty("badgeGradientStartColor")]
        public string BadgeGradientStartColor { get; set; }

        [JsonProperty("badgeType")]
        public string BadgeType { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("cheers")]
        public object[] Cheers { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("earnedMessage")]
        public string EarnedMessage { get; set; }

        [JsonProperty("encodedId")]
        public string EncodedId { get; set; }

        [JsonProperty("image100px")]
        public string Image100px { get; set; }

        [JsonProperty("image125px")]
        public string Image125px { get; set; }

        [JsonProperty("image300px")]
        public string Image300px { get; set; }

        [JsonProperty("image50px")]
        public string Image50px { get; set; }

        [JsonProperty("image75px")]
        public string Image75px { get; set; }

        [JsonProperty("marketingDescription")]
        public string MarketingDescription { get; set; }

        [JsonProperty("mobileDescription")]
        public string MobileDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shareImage640px")]
        public string ShareImage640px { get; set; }

        [JsonProperty("shareText")]
        public string ShareText { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("timesAchieved")]
        public long TimesAchieved { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }
    }

    public partial class Features
    {
        [JsonProperty("exerciseGoal")]
        public bool ExerciseGoal { get; set; }
    }

    public partial class FitbitUser
    {
        public static FitbitUser FromJson(string json) => JsonConvert.DeserializeObject<FitbitUser>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this FitbitUser self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}

