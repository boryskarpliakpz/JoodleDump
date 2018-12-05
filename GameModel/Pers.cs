using System.Runtime.Serialization;

public enum PersoState
{
    Dead,
    Bad,
    Well,
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
