using System;
using System.Collections.Generic;
using System.IO;
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
       // [DataMember]
        //public Pers Personage { get; set; }

        [DataMember]
        public List<Event> Events { get; set; } 
        [DataMember]
        public List<Platform> Platforms { get; set;  }

        GameSession()
        {
            //Personage = new Pers(PersoState.Dead, 3, new Point(0, 0));
            Events = new List<Event>()
            {
                new Event(){ Name = "Something good", ModelChanges = "Add health"},
                new Event(){Name = "Something bad", ModelChanges = "Decrease health"}
            };
            Platforms = new List<Platform>()
            {
                new Platform(){ PlatformType = PlatformType.Stable, Position = "0 1"}, //new Point(0, 1)},
                new Platform(){ PlatformType = PlatformType.Stable, Position = "0 1"}, //new Point(0, 2)},
                new Platform(){ PlatformType = PlatformType.Unstable, Position = "0 1"}, //new Point(0, 3)},
                new Platform(){ PlatformType = PlatformType.Stable, Position = "0 1"}, //new Point(0, 4)},
                new Platform(){ PlatformType = PlatformType.Unstable, Position = "0 1"}, //new Point(0, 5)},
                new Platform(){ PlatformType = PlatformType.Unstable, Position = "0 1"} //new Point(0, 5)}
            };
        }
        public void Save()
        {
            DataSerializer.SerializeData(DataPath, this);
        }

        public static GameSession Load()
        {
            if(File.Exists(DataPath))
                return DataSerializer.DeserializeItem(DataPath);

            return new GameSession();
        }

        public static void update()
        {
            GameSession gameSession = new GameSession();
            gameSession.Save();
        }

        public static void Main(string[] args)
        {
        }
    }

}
