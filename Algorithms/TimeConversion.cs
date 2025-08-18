using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
         //convert string s to datetime format and extract time 
        DateTime convertedTime = DateTime.ParseExact(s, "hh:mm:sstt", CultureInfo.InvariantCulture);
        
        //extract AM/PM from the string 
        string ampm = s.Substring(8,2);
        int hour = convertedTime.Hour;
        int minutes = convertedTime.Minute;
        int seconds = convertedTime.Second;
      
        if(ampm == "AM" && hour == 12){
            hour = 0;
        }
        if(ampm == "PM"){
           hour += 12;
        }
        
        return convertedTime.ToString("HH:mm:ss");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
