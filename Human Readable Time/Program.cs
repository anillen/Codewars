using System;

public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        var ts = TimeSpan.FromSeconds(seconds);
        return $"{Process(ts.Hours + ts.Days * 24)}:{Process(ts.Minutes)}:{Process(ts.Seconds)}";
    }
    private static string Process(int number)=>number < 10 ? $"0{number}":$"{number}";
}