using System.Numerics;

namespace Numerics
{
    public struct Int3
    {
        public int X;
        public int Y;
        public int Z;

        public static Int3 operator +(Int3 a, Int3 b)
        {
            return new Int3
            {
                X = a.X + b.X,
                Y = a.Y + b.Y,
                Z = a.Z + b.Z
            };
        }

        public static Vector3 operator +(Int3 a, Vector3 b)
        {
            return new Vector3
            {
                X = a.X + b.X,
                Y = a.Y + b.Y,
                Z = a.Z + b.Z
            };
        }

        public static Vector3 operator +(Vector3 a, Int3 b)
        {
            return new Vector3
            {
                X = a.X + b.X,
                Y = a.Y + b.Y,
                Z = a.Z + b.Z
            };
        }

        public static Vector3 operator *(Int3 a, float b)
        {
            return new Vector3(a.X * b, a.Y * b, a.Z * b);
        }

        public static Double3 operator *(Int3 a, double b)
        {
            return new Double3
            {
                X = a.X * b,
                Y = a.Y * b,
                Z = a.Z * b
            };
        }
    }
}