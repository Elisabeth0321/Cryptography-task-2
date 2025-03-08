using System;

namespace Lab2
{
    public class StreamCipher
    {
        public byte[] KeyStream { get; private set; }

        public StreamCipher(uint seed)
        {
            KeyStream = GenerateKeyStream(seed);
        }

        private byte[] GenerateKeyStream(uint seed)
        {
            Random rnd = new Random((int)seed);
            byte[] keyStream = new byte[256];
            rnd.NextBytes(keyStream);
            return keyStream;
        }

        public byte[] Encode(byte[] data)
        {
            byte[] encrypted = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                encrypted[i] = (byte)(data[i] ^ KeyStream[i % KeyStream.Length]);
            }
            return encrypted;
        }
    }
}

