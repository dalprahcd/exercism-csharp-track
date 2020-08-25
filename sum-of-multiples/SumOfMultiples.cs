using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var naturalDividers = 
            from n in Enumerable.Range(1, max - 1)
            from m in multiples
            where m != 0 && n % m == 0
            select n;

        return naturalDividers.Distinct().Sum();
    }
    
    // I rather read the query above.
    /*
    public static int Sum(IEnumerable<int> multiples, int max) => 
        Enumerable
            .Range(1, max - 1)
            .SelectMany(n => multiples
                                .Where(m => m != 0 && n % m == 0)
                                .Select(m => n))
            .Distinct()
            .Sum();
    //*/
}