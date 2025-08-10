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
    
        long totalSum = 0;
        /**minimum and maximum values is initially
        set to the first values of the array because i dont wanna use any functions like MaxValue() 
        **/
        int min = arr[0];
        int max = arr[0];
        
        //loop through the array as usual
        for (int i = 0; i < arr.Count; i++)
        {
            //current = current iteration value and sum it up
            int current = arr[i];
            totalSum += current;
            
            //get the minimum value  store it
            if (current < min)
                min = current;
            //get the maximum value store it
            if (current > max)
                max = current;
        }

        long minSum = totalSum - max;
        long maxSum = totalSum - min;

        Console.WriteLine($"{minSum} {maxSum}");
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
