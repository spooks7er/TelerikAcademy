using System;
using System.Text;

namespace Ex1
{
    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder strB, int startIndex, int length)
        {
            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException("StartIndex cannot be less than zero.");
            }
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException("Length cannot be less than zero.");
            }
            if (startIndex >= strB.Length || startIndex + length > strB.Length || length > strB.Length - startIndex)
            {
                throw new ArgumentOutOfRangeException("Index and length must refer to a location within the string.");
            }

            StringBuilder result = new StringBuilder();

            for (int i = startIndex; i < length; i++)
            {
                result.Append(strB[i]);
            }

            return result;
        }

        public static StringBuilder Substring(this StringBuilder strB, int startIndex)
        {
            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException("StartIndex cannot be less than zero.");
            }
            if (startIndex > strB.Length)
            {
                throw new ArgumentOutOfRangeException("startIndex cannot be larger than length of string.");
            }

            StringBuilder result = new StringBuilder();

            for (int i = startIndex; i < strB.Length; i++)
            {
                result.Append(strB[i]);
            }

            return result;
        }
    }
}
