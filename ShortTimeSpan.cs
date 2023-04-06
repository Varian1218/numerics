namespace Numerics
{
    public readonly struct ShortTimeSpan
    {
        public ShortTimeSpan(float seconds)
        {
            Seconds = seconds;
        }

        public float Seconds { get; }

        public static ShortTimeSpan operator -(ShortTimeSpan a, ShortTimeSpan b)
        {
            return new ShortTimeSpan(a.Seconds - b.Seconds);
        }

        public static bool operator >(ShortTimeSpan a, float b)
        {
            return a.Seconds > 0;
        }

        public static bool operator <(ShortTimeSpan a, float b)
        {
            return a.Seconds < 0;
        }
    }
}