using System;
using System.Text;

namespace Lab2
{
    public static class Utils
    {
        public static string BytesToBinary(byte[] bytes)
        {
            StringBuilder binaryString = new StringBuilder();
            foreach (byte b in bytes)
            {
                binaryString.Append(Convert.ToString(b, 2).PadLeft(8, '0')).Append(" ");
            }
            return binaryString.ToString().Trim();
        }

        public static byte[] BinaryToBytes(string binaryString)
        {
            binaryString = binaryString.Replace(" ", "");

            int remainder = binaryString.Length % 8;
            if (remainder != 0)
            {
                int padding = 8 - remainder;
                binaryString = binaryString.PadRight(binaryString.Length + padding, '0');
            }

            int byteCount = binaryString.Length / 8;
            byte[] bytes = new byte[byteCount];

            for (int i = 0; i < byteCount; i++)
            {
                string byteString = binaryString.Substring(i * 8, 8);
                bytes[i] = Convert.ToByte(byteString, 2);
            }

            return bytes;
        }
    }
}
