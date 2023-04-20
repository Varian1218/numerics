namespace Numerics
{
    public struct Ints
    {
        private int _key;
        private int _value;

        public static implicit operator int(Ints value)
        {
            return value._value ^ value._key;
        }

        public static implicit operator Ints(int value)
        {
#if INTS_USE_DATE_TIME
            var key = DateTime.Now.Millisecond;
#else
            const int key = 20042023;
#endif
            return new Ints
            {
                _key = key,
                _value = value ^ key
            };
        }
    }
}