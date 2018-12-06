using System.Runtime.Serialization;

[DataContract]
public enum PersoState
{
    [EnumMember]
    Dead,
    [EnumMember]
    Bad,
    [EnumMember]
    Well,
    [EnumMember]
    Nice
}

namespace GameModel
{
    [DataContract]
    public class Pers
    {
        [DataMember]
        public PersoState PersoState { get; set; }
        [DataMember]
        public int HealthLeft { get; set; }

        [DataMember]
        Point Position { get; set; }
        Pers() { HealthLeft = 3; }

        public Pers(PersoState persoState, int healthLeft, Point position)
        {
            PersoState = persoState;
            HealthLeft = healthLeft;
            Position = position;
        }
    }
}
