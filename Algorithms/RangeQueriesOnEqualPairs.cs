// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class SolutionSimple
{
    // hackerrank is organizing a chess tournament for its employees. There are n employees, each with unique ID from 1 to n and the employee ID x has a rating of rating[x]. Two employees can form a team if they have the same rating and each employee can be part of only one team. There are q queries, each of the form (l,r). 
    // For each query, determine the maximum number of teams that can be formed from employees with IDs between l and r inclusive. Each query is independent of others. For example: n=4 rating = [2,3,4,2] q = 2 queries = [[1,4],[3,4]] 
    // For the first query all employees are considered. Employees with IDs 1 and 4 can be teamed as their ratings are the same. There are no other team formations possible. The number of teams are 1. For the second query, employees 3 and 4 are considered, their ratings are 4,2. Since their ratings are different no teams can be formed. The number of teams are 0. The answer is [1,0]
    
    
    public static List<int> MaxTeamsPerQuery(int n, List<int> rating, List<(int l, int r)> queries){
        
        var ans = new List<int>(queries.Count);
        
        foreach(var(l,r) in queries)
        {
            //storing the frequency of the rating
            //new Dictionary<int,int>() just creates an empty map from int → int.
            var freq = new Dictionary<int, int>();
            
            //traverse through the range between left and right of queries
        
            for (int id = l; id <= r; id++)
            {
                int val = rating[id - 1];
                if (!freq.TryGetValue(val, out int c)) c = 0;
                freq[val] = c + 1;
            }
            
            int teams = 0;
            foreach (var kv in freq)
            {
                teams += kv.Value / 2;
            }
            ans.Add(teams);
        }
         return ans;
    }
    
    
    
    public static void Main()
    {
        int n = 4;
        var rating = new List<int> { 2, 3, 4, 2 };
        var queries = new List<(int l, int r)>
        {
            (1, 4),
            (3, 4)
        };

        var res = MaxTeamsPerQuery(n, rating, queries);
        Console.WriteLine(string.Join(" ", res)); // expected: 1 0
    }
}