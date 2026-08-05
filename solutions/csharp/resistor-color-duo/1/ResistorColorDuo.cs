public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        string[] colornames= new string[]
        {
            "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"
        };

        int svalue=0; int length=colornames.Length;

        for(int i=0;i<length;i++)
        {
            if(colornames[i]==colors[0])
            {
                svalue+=i*10;
            }
            if(colornames[i]==colors[1])
            {
                svalue+=i;
            }
        }
        return svalue;
    }
}
