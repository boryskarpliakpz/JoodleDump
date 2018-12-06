using System;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace GameModel
{
    [DataContract]
    public struct Point
    {
        [DataMember]
        public int X, Y;
        
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(string formatted)
        {
            var coords = formatted.Split(' ');
            X = Convert.ToInt32(coords[0]);
            Y = Convert.ToInt32(coords[1]);
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", X, Y);
        }
    }
}