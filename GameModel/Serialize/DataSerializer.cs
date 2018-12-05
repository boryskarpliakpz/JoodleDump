using System.IO;
using System.Runtime.Serialization;

namespace GameModel
{
    class DataSerializer
    {
        public static void SerializeData(string filename, GameSession data)
        {
            var formatter = new DataContractSerializer(typeof(GameSession));
            var s = new FileStream(filename, FileMode.Create);
            formatter.WriteObject(s, data);
            s.Close();
        }
        public static GameSession DeserializeItem(string filename)
        {
            var formatter = new DataContractSerializer(typeof(GameSession));
            var s = new FileStream(filename, FileMode.Open);

            GameSession res = (GameSession) formatter.ReadObject(s);
            s.Close();
            return res;
        }
    }
}
