public static class Bob
{
    public static string Response(string statement)
    {
        if(string.IsNullOrWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }

        else if(isupper(statement) && statement.Trim().EndsWith("?"))
        {
            return "Calm down, I know what I'm doing!";
        }
        else if(statement.Trim().EndsWith("?"))
        {
            return "Sure.";
        }
        else if(isupper(statement))
        {
            return "Whoa, chill out!";
        }
        
        else
        {
            return "Whatever." ;
        }
        
    }

    private static bool isupper(string statement)
    {
        
        bool hasLetters = statement.Any(char.IsLetter);
    return hasLetters && statement.ToUpper() == statement;
    }
}