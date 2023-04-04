namespace Numerics
{
    public struct Ints
    {
        private int _value;

        public static implicit operator int(Ints value)
        {
            return value._value;
        }

        public static implicit operator Ints(int value)
        {
            return new Ints
            {
                _value = value
            };
        }
    }
}