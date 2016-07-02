namespace LongestString
{
    using System;
    using StringExtentions;

    public class Test
    {
        public static void Main()
        {
            var words = new string[] { "lorem", "ipsum", "dolor", "sit", "amet", "consectetuer" };

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("17. Longest string in array");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(words.FindLongestString());
        }
    }
}