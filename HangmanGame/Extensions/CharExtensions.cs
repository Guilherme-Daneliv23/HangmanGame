using System;
using System.Globalization;
using System.Text;


namespace System
{
    static class CharExtensions
    {
        public static bool CompareCharArrayWithList(this char[] array1, List<char> array2)
        {
            Console.WriteLine("Foi");
            if (array1.Length != array2.Count)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }


        public static char RemoveAssent(this char ch)
        {
            string normalizedText = ch.ToString().Normalize(NormalizationForm.FormD);


            foreach (char c in normalizedText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    return c;
                }
            }

            return ch;
        }

    }
}
