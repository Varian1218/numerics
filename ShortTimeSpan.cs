namespace Numerics
{
    public readonly struct ShortTimeSpan
    {
        public ShortTimeSpan(float seconds)
        {
            Seconds = seconds;
        }

        public float Seconds { get; }
    }
}