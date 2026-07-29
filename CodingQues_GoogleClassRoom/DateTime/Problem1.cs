namespace CalculatorProblems;

public class Problem1
{
    public static void Run()
    {
        DateTimeOffset utcNow = DateTimeOffset.UtcNow;
        Console.WriteLine($"GMT Time: {utcNow.ToString("yyyy-MM-dd HH:mm:ss zzz")}");

        TimeZoneInfo istZone = GetTimeZone("India Standard Time", "Asia/Kolkata");
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcNow, istZone);
        Console.WriteLine($"IST Time: {istTime.ToString("yyyy-MM-dd HH:mm:ss zzz")}");

        TimeZoneInfo pstZone = GetTimeZone("Pacific Standard Time", "America/Los_Angeles");
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcNow, pstZone);
        Console.WriteLine($"PST Time: {pstTime.ToString("yyyy-MM-dd HH:mm:ss zzz")}");
    }

    private static TimeZoneInfo GetTimeZone(string windowsId, string ianaId)
    {
        try
        {
            return TimeZoneInfo.FindSystemTimeZoneById(windowsId);
        }
        catch
        {
            return TimeZoneInfo.FindSystemTimeZoneById(ianaId);
        }
    }
}
