using System.Runtime.Serialization;

namespace GameModel
{
    [DataContract]
    public class Event
    {
        public Event(string name, string modelChanges)
        {
            Name = name;
            ModelChanges = modelChanges;
        }

        [DataMember]
        public string Name { get; set; }
    
        [DataMember]
        public string ModelChanges { get; set; }
    }
}
