using System.Numerics;

namespace Numerics
{
    public struct Int3
    {
        public static readonly Int3 Back = new()
        {
            X = 0,
            Y = 0,
            Z = -1
        };

        public static readonly Int3 Down = new()
        {
            X = 0,
            Y = -1,
            Z = 0
        };

        public static readonly Int3 Forward = new()
        {
            X = 0,
            Y = 0,
            Z = 1
        };

        public static readonly Int3[] FourDirs;

        public static readonly Int3 Left = new()
        {
            X = -1,
            Y = 0,
            Z = 0
        };

        public static readonly Int3 Right = new()
        {
            X = 1,
            Y = 0,
            Z = 0
        };

        public static readonly Int3 Up = new()
        {
            X = 0,
            Y = 1,
            Z = 0
        };

        public static readonly Int3 Zero = new()
        {
            X = 0,
            Y = 0,
            Z = 0
        };

        public int X;
        public int Y;
        public int Z;

        static Int3()
        {
            FourDirs = new[]
            {
                Back,
                Forward,
                Left,
                Right,
            };
        }

        public static Int3 operator +(Int3 a, Int3 b)
        {
            return new Int3
            {
                X = a.X + b.X,
                Y = a.Y + b.Y,
                Z = a.Z + b.Z
            };
        }

        public static Double3 operator +(Int3 a, Double3 b)
        {
            return new Double3
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

        public static Double3 operator *(double a, Int3 b)
        {
            return new Double3
            {
                X = a * b.X,
                Y = a * b.Y,
                Z = a * b.Z
            };
        }

        public static bool operator ==(Int3 a, Int3 b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        public static bool operator !=(Int3 a, Int3 b)
        {
            return a.X != b.X && a.Y != b.Y && a.Z != b.Z;
        }

        public static implicit operator Vector3(Int3 value)
        {
            return new Vector3(value.X, value.Y, value.Z);
        }
    }
}