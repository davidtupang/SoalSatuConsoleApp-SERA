using System;

namespace SoalSatuConsoleApp_SERA
{
    public class ValueType
    {
        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}