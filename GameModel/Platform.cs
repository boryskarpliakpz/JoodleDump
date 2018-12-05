using System.Runtime.Serialization;

public enum PlatformType
{
    Stable,
    Unstable
}

namespace GameModel
{
    [DataContract]
    public class Platform
    {
        [DataMember]
        public PlatformType PlatformType;

        [DataMember]
        public Point Position;

        public Platform(PlatformType platformType, Point position)
        {
            PlatformType = platformType;
            Position = position;
        }
    }
}
