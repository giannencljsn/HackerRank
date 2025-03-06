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
     * Complete the 'arrayManipulation' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static long arrayManipulation(int n, List<List<int>> queries)
    {
         // a b k
        // 1 5 3
        // 4 8 7
        // 6 9 1
        // Variable to store the result type long for big integer type  
        // n+1 for easier prefix sum calculation
        long[] queryResult = new long[n + 2];
        
        // Loop through the queries array to get the indices of a, b, k
        for (int i = 0; i < queries.Count; i++){
            int a = queries[i][0]; //zero-based index start
            int b = queries[i][1]; //Upper bound
            int k = queries[i][2]; // value to add
    
            //Addition starting at index a 
            queryResult[a] += k;
            
            //Stop at index b within bounds
            if(b < n)
                queryResult[b + 1] -= k;
            
        }
        //store the largest value 
        long sum = 0, max =0;
        
        for(int i=1; i <= n; i++){
            sum +=queryResult[i];
            if(sum > max)
                max = sum;
            
        }
        //Return maximum value in the array 
        return max; 
        
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().Trim().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);
        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < m; i++)
        {
            queries.Add(Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList());
        }

        long result = Result.arrayManipulation(n, queries);

        Console.WriteLine(result);
    }
}
