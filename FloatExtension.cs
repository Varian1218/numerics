namespace Numerics
{
    public static class FloatExtension
    {
        public static int Normalize(this float value)
        {
            return value switch
            {
                > 0 => 1,
                < 0 => -1,
                _ => 0
            };
        }
    }
}