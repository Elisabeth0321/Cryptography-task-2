using System;

namespace Lab2
{
    public class StreamCipher
    {
        private uint lfsr;
        private const uint Tap = (1 << 25) | (1 << 7) | (1 << 6) | (1 << 0); // x^26 + x^8 + x^7 + x + 1
        public byte[] KeyStream { get; private set; }

        public StreamCipher(uint seed)
        {
            lfsr = seed & 0x3FFFFFF; // Ограничение 26 битами
        }

        private byte GetNextBit()
        {
            byte newBit = Parity(lfsr & Tap);
            lfsr = ((lfsr << 1) & 0x3FFFFFF) | newBit;
            return newBit;
        }

        public byte[] Encode(byte[] inputBytes)
        {
            int bitLength = inputBytes.Length * 8;
            int byteLength = (bitLength + 7) / 8;
            KeyStream = new byte[byteLength];
            byte[] encryptedBytes = new byte[inputBytes.Length];

            byte currentByte = 0;
            int bitCount = 0;

            for (int i = 0; i < Math.Min(26, bitLength); i++)
            {
                currentByte = (byte)((currentByte << 1) | ((lfsr >> (25 - i)) & 1));
                bitCount++;

                if (bitCount == 8)
                {
                    KeyStream[(i + 1) / 8 - 1] = currentByte;
                    currentByte = 0;
                    bitCount = 0;
                }
            }

            for (int i = 26; i < bitLength; i++)
            {
                currentByte = (byte)((currentByte << 1) | GetNextBit());
                bitCount++;

                if (bitCount == 8)
                {
                    KeyStream[(i + 1) / 8 - 1] = currentByte;
                    currentByte = 0;
                    bitCount = 0;
                }
            }

            if (bitCount > 0)
            {
                KeyStream[bitLength / 8] = (byte)(currentByte << (8 - bitCount));
            }

            for (int i = 0; i < inputBytes.Length; i++)
            {
                encryptedBytes[i] = (byte)(inputBytes[i] ^ KeyStream[i]);
            }

            return encryptedBytes;
        }

        private byte Parity(uint x)
        {
            x ^= x >> 16;
            x ^= x >> 8;
            x ^= x >> 4;
            x ^= x >> 2;
            x ^= x >> 1;
            return (byte)(x & 1);
        }
    }
}
