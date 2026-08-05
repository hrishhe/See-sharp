public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type

    public static string SubstringAfter(this string input, string delimiter)
    {
       int index=input.IndexOf(delimiter);
       if(index==-1)
       {
        return "";
       }
       else
       {
        int startIndex=index+delimiter.Length;
        return input.Substring(startIndex);
       }
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string input,string sDelimiter,string eDelimiter)
    {
        int sIndex=input.IndexOf(sDelimiter);
        int eIndex=input.IndexOf(eDelimiter);
        if(sIndex==-1 || eIndex==-1)
        {
            return "";
        }
        else if(sIndex>eIndex)
        {
            return "";
        }
        else
        {

            int start=sIndex+sDelimiter.Length;

            int end=eIndex-start;
            return input.Substring(start,end);
            
        }
        
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string input)
    {
        int index=input.IndexOf(":");
        if(index==-1 || input.Length <= index + 1)
        {
            return "";
        }
        else
        {
            return input.Substring(index+2);
        }
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string input)
    {
        int sIndex=input.IndexOf("[");
        int eIndex=input.IndexOf("]");
        if(sIndex==-1 || eIndex==-1 || sIndex>eIndex)
        {
            return "";
        }
        else
        {
            int length= (eIndex-sIndex)-1;
            return input.Substring(sIndex+1,length);
        }
    }
}