using System;
namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static bool IsOdd(this int num)
        {
            if (!(num % 2 == 0))
            {
                return true;
            }
            return false;
        }

        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool DoesContainDigit(this string str)
        {
            foreach (var chr in str)
            {
                if (char.IsDigit(chr))
                {
                    return true;
                }
            }
            return false;
        }

        public static void ToCapitalize(this string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine(char.ToUpper(str[0])+str.Substring(1));
            }
        }

        public static int[] GetValueIndexes(this string str, char ch)
        {
            int[] indexes = new int[0];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    Array.Resize(ref indexes, indexes.Length + 1);
                    indexes[indexes.Length - 1] = i;
                }
            }
            return indexes;
        }
    }
}
