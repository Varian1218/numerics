using System;
using System.IO;
using System.Security.Cryptography;

namespace Numerics
{
    public struct Floats
    {
        private byte[] _iv;
        private byte[] _key;
        private byte[] _value;

        public static implicit operator float(Floats value)
        {
            using var aes = Aes.Create();
            aes.IV = value._iv;
            aes.Key = value._key;

            using var ms = new MemoryStream(value._value);
            using var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read);
            var bytes = new byte[sizeof(float)];
            var _ = cs.Read(bytes, 0, bytes.Length);
            return BitConverter.ToSingle(bytes, 0);
        }

        public static implicit operator Floats(float value)
        {
            using var aes = Aes.Create();
            using var ms = new MemoryStream();
            using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var bytes = BitConverter.GetBytes(value);
                cs.Write(bytes, 0, bytes.Length);
            }
            return new Floats
            {
                _iv = aes.IV,
                _key = aes.Key,
                _value = ms.ToArray()
            };
        }
    }
}