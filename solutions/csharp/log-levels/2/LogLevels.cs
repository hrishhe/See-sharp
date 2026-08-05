using System.Runtime.InteropServices.Marshalling;

static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Substring(logLine.IndexOf(':') + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        var startIndex = logLine.IndexOf('[') + 1;
        var endIndex=logLine.IndexOf(']');
        if(startIndex>0 && endIndex>startIndex)
        {
            string log = logLine.Substring(startIndex, endIndex - startIndex);
            return log.ToLower();
        }
        return string.Empty;
    
    }

    public static string Reformat(string logLine)
    {
       return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
