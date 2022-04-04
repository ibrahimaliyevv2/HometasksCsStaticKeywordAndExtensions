using System;
namespace ClassLibrary
{
    public static class ExtensionMethods
    {
       
            public static bool CheckFullname(this string str)
            {
                int count = 0;
                foreach (var chr in str)
                {
                    if (chr == ' ')
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    string[] strArr = str.Split(" ");
                    if (char.IsUpper(strArr[0][0]) && char.IsUpper(strArr[1][0]))
                    {
                        for (int i = 1; i < strArr[0].Length; i++)
                        {
                            if (char.IsUpper(strArr[0][i]))
                            {
                                return false;
                            }
                        }
                        for (int i = 1; i < strArr[1].Length; i++)
                        {
                            if (char.IsUpper(strArr[1][i]))
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                }
                return false;

            }

        public static bool CheckGroupNo(this string groupNo)
        {
            if (groupNo.Length == 4)
            {
                if (char.IsUpper(groupNo[0]) && char.IsDigit(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}