using System;
using System.Text;

public static class ReverseString
{
    //-=--- doning this by converting string to char array to spit each chafracter and put that in an array
    //------ after  forming an array og characters, no i can use Array.Reverse(char array[]) to reverse;


    // public static string Reverse(string input)
    // {
    //     char[] i = input.ToCharArray();
    //     Array.Reverse(i);
    //     return new string(i);

    // }


//-------=-using just the string and its methods to reverse the string, using Linq

    // public static string Reverse(string input)
    // {
    //     string rev= string.Concat(input.Reverse());

    //     return rev;
    // }



//-----=--- reversing the string using a for loop, starting from the end of the string and adding each character to a new string


//  public static string Reverse(string input)  // O[N^2] time complexity; BAD
//     {
//         string rev="";
//         for (int i= input.Length-1; i>=0; i--)
//         {
//             rev += input[i];

//         }
//         return rev;
//     }

//---=--------

public static string Reverse(string input) //complexity O[n] 
    {
        StringBuilder rev= new StringBuilder();
        for (int i= input.Length -1; i>=0; i--)
        {
            rev.Append(input[i]);

        }
        return rev.ToString();

    }


}