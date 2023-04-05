using System;

namespace Numerics
{
    public static class Double3Extension
    {
        public static Double3 Abs(this Double3 value)
        {
            return new Double3
            {
                X = Math.Abs(value.X),
                Y = Math.Abs(value.Y),
                Z = Math.Abs(value.Z)
            };
        }
    }
}