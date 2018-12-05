using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GameModel
{
    [DataContract]
    public class GameSession
    {
        static string DataPath = "predefined.dat";
        [DataMember]
        public Pers pers;
        [DataMember]
        public IEnumerable<Event> Events { get; set; } 
        [DataMember]
        public IEnumerable<Platform> Platforms { get; set;  }

        GameSession()
        {
            pers = new Pers(PersoState.Dead, 3, new Point(0, 0));
            Events = new List<Event>()
            {
                new Event("Something good", "Add health"),
                new Event("Something bad", "Decrease health")
            };
            Platforms = new List<Platform>()
            {
                new Platform(PlatformType.Stable, new Point(0, 1)),
                new Platform(PlatformType.Stable, new Point(0, 2)),
                new Platform(PlatformType.Unstable, new Point(0, 3)),
                new Platform(PlatformType.Stable, new Point(0, 4)),
                new Platform(PlatformType.Unstable, new Point(0, 5)),
            };
        }
        public void Save()
        {
            DataSerializer.SerializeData(DataPath, this);
        }

        public static GameSession Load()
        {
            return DataSerializer.DeserializeItem(DataPath);
        }

        public static void Main(string[] args)
        {
            GameSession gameSession = new GameSession();
            //gameSession.Save();

            GameSession gameSession2 = GameSession.Load();
            var a = 0;
        }
    }

}
