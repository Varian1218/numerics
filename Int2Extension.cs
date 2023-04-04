namespace Numerics
{
    public static class Int2Extension
    {
        public static int SqrMagnitude(this Int2 value)
        {
            return value.X * value.X + value.Y * value.Y;
        }
    }
}