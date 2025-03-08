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

            if (binaryString.Length % 8 != 0)
            {
                throw new Exception("Неверный формат битовой строки.");
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
