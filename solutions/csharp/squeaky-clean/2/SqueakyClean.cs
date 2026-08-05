using System.Text;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (identifier.Length > 0 && identifier is not null)
        {
            StringBuilder sb = new StringBuilder(identifier);
            sb.Replace(" ", "_");
            sb.Replace("\0", "CTRL");
            sb.Replace("-", "");
            return sb.ToString();


        }

        else if (identifier.Length == 0)
        {
            return "";
        }

        else return "";


    }
}
