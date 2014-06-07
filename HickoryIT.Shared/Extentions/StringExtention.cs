using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HickoryIT.Shared.Extentions
{
    //Extension methods must be defined in a static class
    public static class StringExtension
    {
        // This is the extension method.
        // The first parameter takes the "this" modifier
        // and specifies the type for which the method is defined.
        public static string TrimAndReduce(this string str)
        {
            return ConvertWhitespacesToSingleSpaces(str).Trim();
        }

        public static string RemoveNonASCII(this string value)
        {
            return Regex.Replace(value, @"[^\u0000-\u007F]", string.Empty);
        }

        public static string ConvertWhitespacesToSingleSpaces(this string value)
        {
            return Regex.Replace(value, @"\s+", " ");
        }
        public static byte[] GetBytes(this string str)
        {
            return System.Text.Encoding.UTF8.GetBytes(str);
            //byte[] bytes = new byte[str.Length * sizeof(char)];
            //System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            //return bytes;
        }

        public static int ToInt(this string str)
        {
            return Convert.ToInt32(str);
        }
    }
}
