using System;
using System.Runtime.Serialization;

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

        public override string ToString()
        {
            return String.Format("X = {0} Y = {1}", X, Y);
        }
    }
}