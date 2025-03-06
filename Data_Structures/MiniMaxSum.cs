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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        //Sort the array
        arr.Sort();
        
        //variables / long for handling largest sum in array
        long miniSum = 0;
        long maxSum = 0;
        //loop through each while both excluding the first and last indices
        for(int i=0; i<4; i++){
            miniSum+= arr[i];
        }
        
        for(int i=1; i<5; i++){
            maxSum+= arr[i];
        }
        
        Console.WriteLine($"{miniSum} {maxSum}");
        
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
