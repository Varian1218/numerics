using System.Numerics;

namespace Numerics
{
    public struct Int2
    {
        public static readonly Int2 Zero = new Int2
        {
            X = 0,
            Y = 0
        };

        public int X;
        public int Y;

        public static Int2 operator +(Int2 a, Int2 b)
        {
            return new Int2
            {
                X = a.X + b.X,
                Y = a.Y + b.Y
            };
        }

        public static Vector2 operator *(Int2 a, float b)
        {
            return new Vector2(a.X * b, a.Y * b);
        }

        public static Double2 operator *(Int2 a, double b)
        {
            return new Double2
            {
                X = a.X * b,
                Y = a.Y * b
            };
        }

        // public static implicit Int2((float, float) value)
        // {
        //     var (x, y) = value;
        //     return new Int2
        //     {
        //         X = x,
        //         Y = y
        //     };
        // } 
        public void Deconstruct(out int x, out int y)
        {
            x = X;
            y = Y;
        }
    }
}