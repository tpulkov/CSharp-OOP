﻿namespace StringBuilder.Extentions
{
    using System.Text;

    public static class StringBuilderExtention
    {
        public static StringBuilder Substring(this StringBuilder text, int index, int length)
        {
            var result = new StringBuilder();
            var substring = text.ToString().Substring(index, length);
            result.Append(substring);
            return result;
        }
    }
}
