using static System.Console;

class Date
{
    // 강의에서는 간단히 하기 위해 auto-impl 사용
    // 복습시에는 유효성 여부를 검증하도록 변경해 보세요
    public int Year  { get; set; };
    public int Month { get; set; };
    public int Day   { get; set; };

    public Date(int y, int m, int d) => (Year, Month, Day) = (y, m, d);
}

class Program
{
    public static void Main()
    {
        Date d1 = new Date(2025, 2, 23);

    }
}