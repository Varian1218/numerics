using System;

namespace Numerics
{
    public static class Int3Extension
    {
        public static Int3 Abs(this Int3 value)
        {
            return new Int3
            {
                X = Math.Abs(value.X),
                Y = Math.Abs(value.Y),
                Z = Math.Abs(value.Z)
            };
        }

        public static int SqrMagnitude(this Int3 value)
        {
            return value.X * value.X + value.Y * value.Y + value.Z + value.Z;
        }
    }
}