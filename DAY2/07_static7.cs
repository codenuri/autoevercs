using static System.Console;

class Date
{
    // 강의에서는 간단히 하기 위해 auto-impl 사용
    // 복습시에는 유효성 여부를 검증하도록 변경해 보세요
    public int Year { get; set; };
    public int Month { get; set; };
    public int Day { get; set; };

    private static int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


    public Date(int y, int m, int d) => (Year, Month, Day) = (y, m, d);


    public Date AfterDays(int ds)
    {
        Date tmp = new Date(Year, Month, Day + ds);

        return tmp;
    }

    public static int HowManyDays(int m)
    {
        return days[m - 1];
    }

    public Date Tomorrow()
    {
        Date tmp = new Date(Year, Month, Day + 1); 
        return tmp;
    }

    // 동일 기능을 instance method, static method 로 모두제공
    // 하는 것도 많이 사용되는 기술입니다.
    public static bool IsLeapYear(int y)
    {
        return (y % 400 == 0) || ( (y % 4 == 0) && (y % 100 != 0) ); 
    }

    public bool IsLeapYear()
    {
        // static method 호출하면서 자신의 Year 전달
        return IsLeapYear(Year);
    }
}

class Program
{
    public static void Main()
    {
        // 윤년인지 조사하는 IsLeapYear() 메소드를 제공하고싶다.

        // 다음중 좋은 방법은 ?
        // #1. instance method 로 제공
        Date d  = new Date(2026, 2, 23);
        bool b1 = d.IsLeapYear();

        // #2. static method 로 제공
        bool b2 = Date.IsLeapYear(2026);

    }
}