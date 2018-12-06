using System.Runtime.Serialization;

[DataContract]
public enum PlatformType
{
    [EnumMember]
    Stable,
    [EnumMember]
    Unstable
}

namespace GameModel
{
    [DataContract]
    public class Platform
    {
        [DataMember]
        public PlatformType PlatformType { get; set; }

        [DataMember]
        public string Position { get; set; }

    }
}
