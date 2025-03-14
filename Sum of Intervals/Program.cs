using System;
using System.Collections.Generic;
using System.Linq;

public class Intervals
{  
    public static int SumIntervals((int, int)[] intervals)
    {
        if (intervals == null || intervals.Length == 0)
            return 0;

        Array.Sort(intervals, (a, b) => a.Item1.CompareTo(b.Item1));

        var merged = new List<(int, int)>();
        var currentInterval = intervals[0];

        for (int i = 1; i < intervals.Length; i++)
        {
            var interval = intervals[i];
            int start = interval.Item1;
            int end = interval.Item2;
            int currentStart = currentInterval.Item1;
            int currentEnd = currentInterval.Item2;

            if (start <= currentEnd)
            {
                currentInterval.Item1 = Math.Min(currentStart, start);
                currentInterval.Item2 = Math.Max(currentEnd, end);
            }
            else
            {
                merged.Add(currentInterval);
                currentInterval = interval;
            }
        }

        merged.Add(currentInterval);

        int totalLength = merged.Sum(interval => interval.Item2 - interval.Item1);

        return totalLength;
    }
    
}