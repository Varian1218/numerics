namespace Numerics
{
    public class Floats
    {
        private float _value;

        public static implicit operator float(Floats value)
        {
            return value._value;
        }

        public static implicit operator Floats(float value)
        {
            return new Floats
            {
                _value = value
            };
        }
    }
}