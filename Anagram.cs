using System;
using System.Linq;

public class Anagram
{
    private readonly string baseWord;

    public Anagram(string baseWord)
    {
        this.baseWord = baseWord;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        return potentialMatches.Where(IsAnagram).ToArray();
    }

    public bool IsAnagram(string potentialMatch)
    {
        
        if (potentialMatch.Length != baseWord.Length)
        {
            return false;
        }

        // 2. A word is NOT an anagram of itself (case-insensitive check)
        if (baseWord.Equals(potentialMatch, StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        // 3. Lowercase both and sort their characters
        var sortedBase = baseWord.ToLowerInvariant().OrderBy(c => c);
        var sortedMatch = potentialMatch.ToLowerInvariant().OrderBy(c => c);

        // 4. Compare character sequences
        return sortedBase.SequenceEqual(sortedMatch);
    }
}