namespace Numerics
{
    public static class Int3Extension
    {
        public static int SqrMagnitude(this Int3 value)
        {
            return value.X * value.X + value.Y * value.Y + value.Z + value.Z;
        }
    }
}