namespace Numerics
{
    public static class DoubleExtension
    {
        public static int Normalize(this double value)
        {
            return value switch
            {
                > 0 => 1,
                < 0 => -1,
                _ => 0
            };
        }

        public static double SqrMagnitude(this Double3 value)
        {
            return value.X * value.X + value.Y * value.Y + value.Z * value.Z;
        }
    }
}