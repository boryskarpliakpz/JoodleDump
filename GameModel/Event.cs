using System.Runtime.Serialization;

namespace GameModel
{
    [DataContract]
    public class Event
    {
        [DataMember]
        public string Name { get; set; }
    
        [DataMember]
        public string ModelChanges { get; set; }
    }
}
