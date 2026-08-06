using System.Collections.Generic;

public static class BottleSong
{
    private static readonly Dictionary<int, string> Numbers = new()
    {
        { 0, "no" },
        { 1, "one" },
        { 2, "two" },
        { 3, "three" },
        { 4, "four" },
        { 5, "five" },
        { 6, "six" },
        { 7, "seven" },
        { 8, "eight" },
        { 9, "nine" },
        { 10, "ten" }
    };

    public static IEnumerable<string> Recite(int startBottles, int takeDown)
    {
        List<string> ret = new List<string>();

        for (int i = 0; i < takeDown; i++)
        {
            int current = startBottles - i;
            int next = current - 1;

            string currentWordCap = Capitalize(Numbers[current]);
            string nextWordLower = Numbers[next];

            string currentPlural = current == 1 ? "bottle" : "bottles";
            string nextPlural = next == 1 ? "bottle" : "bottles";

            ret.Add($"{currentWordCap} green {currentPlural} hanging on the wall,");
            ret.Add($"{currentWordCap} green {currentPlural} hanging on the wall,");
            ret.Add("And if one green bottle should accidentally fall,");
            ret.Add($"There'll be {nextWordLower} green {nextPlural} hanging on the wall.");

            // Add an empty line separator between verses (but not after the last verse)
            if (i < takeDown - 1)
            {
                ret.Add("");
            }
        }

        return ret;
    }

    private static string Capitalize(string str)
    {
        if (string.IsNullOrEmpty(str)) return str;
        return char.ToUpper(str[0]) + str.Substring(1);
    }
}