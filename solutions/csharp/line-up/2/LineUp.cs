public static class LineUp
{
    public static string Format(string name, int number)
    {
        string ret;
        if(number >0)
        {
        
        
            if((number%100) ==11||(number%100) ==12||(number%100) ==13)
            {
                ret= $"{number}th";
                return $"{name}, you are the {ret} customer we serve today. Thank you!";
            }
        
        else if (number % 10 ==1)
        {
            ret= $"{number}st";
            return $"{name}, you are the {ret} customer we serve today. Thank you!";
        }
        else if (number % 10 ==2)
        {
            ret= $"{number}nd";
            return $"{name}, you are the {ret} customer we serve today. Thank you!";
        }
        else if (number % 10 ==3)
        {
            ret= $"{number}rd";
            return $"{name}, you are the {ret} customer we serve today. Thank you!";
        }
        else
        {
            ret= $"{number}th";
            return $"{name}, you are the {ret} customer we serve today. Thank you!";
        }

    }

    else return "Not possible to serve negative or zero customers";
    }
}
